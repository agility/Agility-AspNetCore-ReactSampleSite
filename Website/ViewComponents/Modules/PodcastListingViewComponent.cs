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
	public class PodcastListing : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_PodcastListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				int postCount = 100;
				var posts = module.Items
					.Items(rowFilter: null, sort: null, take: postCount, skip: 0)
					.Select(p => p.GetListingViewModel(240));

				var viewModel = new
				{
					items = posts

				};


				return new ReactViewComponentResult("Components.PodcastListing", viewModel);

			});
		}

	}

}