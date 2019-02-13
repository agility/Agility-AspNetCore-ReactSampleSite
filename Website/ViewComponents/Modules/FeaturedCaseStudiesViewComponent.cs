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
	public class FeaturedCaseStudies : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_FeaturedCaseStudies module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var viewModel = new
				{
					title = module.Title,
					primaryButton = module.ParseUrl("PrimaryButton"),
					items = module.CaseStudies.GetByIDs(module.IDs).Select(p => p.GetFeaturedListingViewModel())
				};

				return new ReactViewComponentResult("Components.FeaturedCaseStudies", viewModel);

			});
		}

	}

}