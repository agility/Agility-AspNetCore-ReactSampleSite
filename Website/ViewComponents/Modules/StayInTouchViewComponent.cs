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
	public class StayInTouch : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_StayInTouch module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var vm = new
				{
					title = module.Title,
					links = module.SocialFollowLinks.Items().Select(l => l.ToFrontendProps())
				};

				return new ReactViewComponentResult("Components.StayInTouchBox", vm);
			});
		}

	}

}