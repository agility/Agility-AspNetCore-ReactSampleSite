using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Modules
{
	public class PricingPlans : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_PricingPlans module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				return new ReactViewComponentResult("Components.Pricing",
					new
					{
						title = module.Title,
						items = module.Plans.Items().Select(i => new {
							title = i.Title,
							subtitle = i.Subtitle,
							callToAction = i.CalltoAction.ParseUrl(),
							isRecommended = i.IsRecommended,
							key = i.ContentID,
							description = i.Description,
							icon = i.Icon,
							price = i.Price,
							pricePerUnitLabel = i.PricePerUnitLabel,
							features = i.Features.SortByIDs(i.FeaturesSortIDs).Select(x => x.ToFrontendProps())
						})
					}
				);
			});
		}
	}
}