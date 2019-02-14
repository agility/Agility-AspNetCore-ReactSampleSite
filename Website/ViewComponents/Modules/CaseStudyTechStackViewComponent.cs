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
	public class CaseStudyTechStack : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_CaseStudyTechStack module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var caseStudy = Agility.Web.AgilityContext.GetDynamicPageItem<CaseStudy>();

                if(caseStudy == null)
                    throw new ArgumentNullException("Case study");

				if(string.IsNullOrEmpty(caseStudy.ProductsRenderType))
				{
					caseStudy.ProductsRenderType = "list";
				}

				var viewModel = new
				{
					heading = caseStudy.ProductsHeading,
					subHeading = caseStudy.ProductsSubHeading,
					renderType =  caseStudy.ProductsRenderType,
					logos = !string.IsNullOrEmpty(caseStudy.ProductIDs) ? caseStudy.Products.GetByIDs(caseStudy.ProductIDs).Select(p => new {
						url = p.URL.ParseUrl(),
						_Logo = p.Logo,
						title = p.Title						
					}) : null
				};

				if (caseStudy.ProductsRenderType == "cloud")
				{
					return new ReactViewComponentResult("Components.LogoCloud", viewModel);
				}
				else
				{
					return new ReactViewComponentResult("Components.LogoListing", viewModel);
				}

			});
		}

	}

}