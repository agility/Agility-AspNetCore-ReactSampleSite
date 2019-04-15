using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web;
using Agility.Web.Extensions;
using Agility.Web.Objects;
using Agility.Web.AgilityContentServer;

namespace Website.ViewComponents.Modules
{
	public class PostListing : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_PostListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{



				var posts = module.Posts
					.Items(rowFilter: null, sort: null, take: module.PostCount, skip: 0)
					.Select(p => p.GetListingViewModel());

				var viewModel = new
				{
					posts = posts,
					skip = 0,
					take = module.PostCount,
					type = "Post"
				};


				return new ReactViewComponentResult("Components.PostListing", viewModel);
			});
		}

	}

}