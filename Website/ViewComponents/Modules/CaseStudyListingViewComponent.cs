using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web;
using Agility.Web.Extensions;
using Agility.Web.Objects;
using Agility.Web.AgilityContentServer;

namespace Website.ViewComponents.Modules
{
	public class CaseStudyListing : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_CaseStudyListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var caseStudies = module.CaseStudies
					.Items(rowFilter: null, sort: null, take: module.CaseCount, skip: 0)
					.Select(p => p.GetListingViewModel());

				var viewModel = new
				{
					posts = caseStudies,
					skip = 0,
					take = module.CaseCount
				};

				return new ReactViewComponentResult("Components.PostListing", viewModel);
			});
		}

	}

}