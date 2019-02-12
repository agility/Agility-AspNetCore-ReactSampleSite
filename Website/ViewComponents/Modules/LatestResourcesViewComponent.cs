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
	public class LatestResources : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_LatestResources module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var viewmodel = new
				{
					title = module.Title,
					subTitle = module.SubTitle,
					leftButton = module.ParseUrl("LeftButton"),
					leftBottomTitle = module.LeftTypeTitle,
					items = module.Resources.Items().Select(i => i.GetListingViewModel())
				};

				return new ReactViewComponentResult("Components.LatestResources", viewmodel);
			});
		}

	}

}