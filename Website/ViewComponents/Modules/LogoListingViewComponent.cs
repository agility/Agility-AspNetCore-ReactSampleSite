using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;
using Website.ViewModels;

namespace Website.ViewComponents.Modules
{
	public class LogoListing : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_LogoListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var viewModel = new LogoListingViewModel(module);


				if (module.RenderType == "cloud")
				{
					return new ReactViewComponentResult("Components.LogoCloud", viewModel);
				}
				else
				{
					return new ReactViewComponentResult("Components.LogoListing", viewModel);
				}

			});
		}

	}

}