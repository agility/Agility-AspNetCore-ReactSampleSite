using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;
using Agility.Web;

namespace Website.ViewComponents.Modules
{
	public class InfoBox : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_InfoBox module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				return new ReactViewComponentResult("Components.InfoBox", module);
			});
		}

	}

}