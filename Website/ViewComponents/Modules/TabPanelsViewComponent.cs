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
	public class TabPanels : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_TabPanels module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var viewModel = new
				{
					title = module.Title,
					tabs = module.TabPanels.GetByIDs(module.TabPanelIDs).Select(p => p.ToFrontendProps())
				};

				return new ReactViewComponentResult("Components.TabPanel", viewModel);
			});
		}

	}

}