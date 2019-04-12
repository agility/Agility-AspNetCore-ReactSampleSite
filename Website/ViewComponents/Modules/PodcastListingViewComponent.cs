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
				var sortBy = "Date " + (module.SortOrder == "asc" ? "ASC" : "DESC");
				var podcasts = module.Items
					.Items(null, sortBy, module.ItemsPerPage, 0, out int totalCount)

					.Select(p => p.GetListingViewModel(240));

				var viewModel = new
				{
					podcasts,
					itemsPerPage = module.ItemsPerPage,
					totalCount,
					refName = module.Items.ContentReferenceName,
					sortBy
				};

				return new ReactViewComponentResult("Components.PodcastListing", viewModel);

			});
		}

	}

}