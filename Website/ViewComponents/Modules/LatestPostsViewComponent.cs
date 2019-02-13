using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;
using Agility.Web;

namespace Website.ViewComponents.Modules
{
	public class LatestPosts : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_LatestPosts module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				IQueryable<BlogPost> posts = null;
				if (!string.IsNullOrWhiteSpace(module.CategoryIDs))
				{
					var catIDs = module.CategoryIDs.Split(',');
					posts = module.Posts.Items().AsQueryable();
					posts = posts.Where(p => p.MatchesWith(catIDs)).Take(module.PostCount);
				}
				else
				{
					posts = module.Posts.Items(rowFilter: null, sort: null, take: module.PostCount, skip: 0).AsQueryable();
				}

				var viewmodel = new
				{
					title = module.Title,
					readMoreLabel = module.ReadMoreLabel,
					items = posts.Select(p => p.GetListingViewModel(75))
				};

				return new ReactViewComponentResult("Components.LatestBlogPosts", viewmodel);
			});
		}

	}

}