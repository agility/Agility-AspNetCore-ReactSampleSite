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
	public class LatestResources : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_LatestResources module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var resourceTypeRepo = new AgilityContentRepository<ResourceType>("ResourceTypes");
				var resourceTypes = resourceTypeRepo.Items()
													.Select(r => new
													{
														title = r.Title,
														key = r.ContentID
													});

				var viewmodel = new
				{
					fetchUrl = "/Listing/Resources",
					types = resourceTypes,
					title = module.Title,
					subTitle = module.SubTitle,
					leftButton = module.LeftButton.ParseUrl(),
					leftBottomTitle = module.LeftTypeTitle,
					items = module.Resources
								  .Items(rowFilter: null, sort: "ItemOrder", take: 100, skip: 0)
								  .Select(i => i.GetListingViewModel())
				};

				return new ReactViewComponentResult("Components.FilteredListing", viewmodel);
			});
		}

	}

}