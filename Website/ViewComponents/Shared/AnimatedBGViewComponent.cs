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
	public class AnimatedBG : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync()
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				return new ReactViewComponentResult("Components.AnimatedBg");
			});
		}

	}

}