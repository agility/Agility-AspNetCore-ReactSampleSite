using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.ViewModels;
using Website.AgilityModels;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Modules
{
	public class LogoListing : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_ContentPanel module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				// var viewModel = new PanelSliderViewModel();

				// var panels = module.Panels.GetByIDs(module.PanelsIDs).ToList();

				// viewModel.Panels = panels;

				// return new ReactViewComponentResult("Components.PanelSlider", viewModel);
				return Content("TODO: implement LogoListing");

			});
		}

	}

}