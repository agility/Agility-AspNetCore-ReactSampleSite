using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;
using Agility.Web;

namespace Website.ViewComponents.Shared
{
	public class GlobalScripts : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync()
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var ret = new ReactViewComponentResult("Components.GlobalScripts");
				ret.ClientOnly = true;
				return ret;
			});
		}

	}

}