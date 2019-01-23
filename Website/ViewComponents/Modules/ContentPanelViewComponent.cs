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
	public class ContentPanel : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_ContentPanel module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var panel = module.Panel.GetByID(module.PanelID).ToFrontendProps();

				return new ReactViewComponentResult("Components.ContentPanel", module);
			});
		}

	}

}