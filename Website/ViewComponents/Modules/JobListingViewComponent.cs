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
	public class JobListing : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_JobListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var viewModel = new
				{
					title = module.Title,
					sideTitle = module.SideTitle,
					sideBody = module.SideBody,
					sideLink = module.SideLink.ParseUrl(),
					jobs = module.Jobs.Items().Select(p => p.ToFrontendProps())
				};

				return new ReactViewComponentResult("Components.JobListing", viewModel);

			});
		}

	}

}