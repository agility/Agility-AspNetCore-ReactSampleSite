using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Modules
{
	public class LogoListing : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_LogoListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				//TODO: implement viewmodel
				if(module.RenderType == "cloud") {
					return new ReactViewComponentResult("Components.LogoCloud", module);
				} else {
					return new ReactViewComponentResult("Components.LogoListing", module);
				}



			});
		}

	}

}