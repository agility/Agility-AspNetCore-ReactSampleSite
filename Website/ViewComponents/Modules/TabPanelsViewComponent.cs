using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Website.AgilityModels;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Modules
{
	public class TabPanels : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_FeatureBlocks module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				return Content("TODO: implement TabPanels ");

			});
		}

	}

}