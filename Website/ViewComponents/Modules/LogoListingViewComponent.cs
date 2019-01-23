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
	public class LogoListing : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_LogoListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var viewModel = new
				{
					renderType = module.RenderType,
					primaryButton = module.ParseUrl("PrimaryButton"),
					secondaryButton = module.ParseUrl("SecondaryButton"),
					logos = module.Logos.SortByIDs(module.LogoIDs).Select(p => p.ToFrontendProps())
				};

				return new ReactViewComponentResult("Components.LogoListing", viewModel);

			});
		}

	}

}