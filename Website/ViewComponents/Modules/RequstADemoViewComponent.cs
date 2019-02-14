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
	public class RequestADemo : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_RequestADemo module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				return new ReactViewComponentResult("Components.RequestADemo", module.ToFrontendProps())
				{
					ClientOnly = true //HACK - remove 
				};
			});
		}

	}

}