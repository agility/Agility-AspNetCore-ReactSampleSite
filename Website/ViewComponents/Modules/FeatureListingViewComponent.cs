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
	public class FeatureListing : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_FeatureListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var tags = module.CustomTagstoHighlight.Items()
					.Select(r => new
					{
						title = r.Title,
						key = r.ContentID
					});

				string fetchUrl = $"/Listing/Features?refName={module.FeatureBlocks.ContentReferenceName}&labelIDs={HttpUtility.UrlEncode(module.CustomTagsToHighlightIDs)}";

				var viewmodel = new
				{
					fetchUrl = fetchUrl,
					types = tags,
					title = module.Title,
					subTitle = module.Subtitle,
					leftButton = module.ParseUrl("LeftButton"),
					leftBottomTitle = module.LeftTypeTitle,
					items = module.FeatureBlocks.Items(rowFilter: null, sort: null, take: 100, skip: 0)
						.Select(i => i.GetFeatureListingViewModel(module.CustomTagsToHighlightIDs))
				};

				return new ReactViewComponentResult("Components.FilteredListing", viewmodel);
			});
		}

	}

}