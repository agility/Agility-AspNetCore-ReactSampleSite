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
	public class CaseStudyDetails : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_CaseStudyDetails module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var resource = Agility.Web.AgilityContext.GetDynamicPageItem<Resource>();

				var viewModel = new
				{

					resource = resource.ToFrontendProps()
				};


				return new ReactViewComponentResult("Components.CaseStudyDetails", viewModel);
			});
		}

	}

}