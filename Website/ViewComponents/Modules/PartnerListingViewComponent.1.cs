using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;
using Agility.Web;
using System.Web;

namespace Website.ViewComponents.Modules
{
	public class PartnerListing : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_PartnerListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{



				var tags = module.Tags.Items()
									   .Select(r => new
									   {
										   title = r.Title,
										   key = r.ContentID
									   });

				string fetchUrl = $"/Listing/Partners?refName={module.Partners.ContentReferenceName}&labelIDs={HttpUtility.UrlEncode(module.TagIDs)}&dynPagePath={HttpUtility.UrlEncode(module.DynamicPagePath)}";

				var viewmodel = new
				{
					fetchUrl = fetchUrl,
					types = tags,
					title = module.Title,
					subTitle = module.SubTitle,
					leftButton = module.ParseUrl("LeftButton"),
					leftBottomTitle = module.LeftTypeTitle,
					items = module.Partners
								  .Items(rowFilter: null, sort: null, take: 100, skip: 0)
								  .Select(i => i.GetPartnerListingViewModel(module.TagIDs, module.DynamicPagePath))
				};

				return new ReactViewComponentResult("Components.LatestResources", viewmodel);
			});
		}

	}

}