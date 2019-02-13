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
	public class CaseStudyContentPanel : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_CaseStudyContentPanel module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var caseStudy = Agility.Web.AgilityContext.GetDynamicPageItem<CaseStudy>();


                if(caseStudy == null)
                    throw new ArgumentNullException("Case study");

                var caseStudyFront = caseStudy.ToFrontendProps();

				var viewModel = new
				{
					ImagePosition = caseStudyFront.ImagePosition,
                    Image = caseStudyFront.Image,
                    StudyImage = caseStudyFront.CustomerLogo,
                    Title = caseStudyFront.Title,
                    ContentPanelCopy = caseStudyFront.ContentPanelCopy,
                    fgColor = caseStudyFront.BrandFGColor,
                    bgColor = caseStudyFront.BrandBGColor
				};

				return new ReactViewComponentResult("Components.CaseStudyContentPanel", viewModel);
			});
		}

	}

}