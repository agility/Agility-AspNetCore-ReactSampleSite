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
	public class CaseStudyDetails : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_CaseStudyDetails module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var caseStudy = Agility.Web.AgilityContext.GetDynamicPageItem<CaseStudy>();

				if(caseStudy == null)
					throw new ArgumentNullException();

				var currentPage = AgilityContext.Page;

				ResourceType resourceType = new ResourceType()
				{
					Title = "Case Study"
				};

				string description = currentPage.MetaTags;
				if (string.IsNullOrWhiteSpace(description))
				{
					description = caseStudy.Excerpt.Truncate(300, "...", true, true).Replace("\"", "&quot;");
					currentPage.MetaTags = description;
				}

				string canonicalUrl = Request.GetEncodedUrl();
				if (canonicalUrl.Contains("?")) canonicalUrl = canonicalUrl.Substring(0, canonicalUrl.IndexOf("?"));

				currentPage.MetaTagsRaw = Utils.SEOUtils.GetRawMetaTags(
					existingRawTags: currentPage.MetaTagsRaw,
					title: caseStudy.Title,
					canonicalUrl: canonicalUrl,
					category: resourceType?.Title,
					description: description,
					image: caseStudy.Image
				);

				var viewModel = new
				{
					Metrics = caseStudy.Metrics.Items().Select(i => new { 
						Title = i.Key,
						i.Value
					}					
					),
					bgColor = caseStudy.BrandBGColor,
					Body = caseStudy.TextBlob,
					RightContentCopy = caseStudy.RightContentCopy,
					Quote = caseStudy.Quote
				};

				return new ReactViewComponentResult("Components.CaseStudyDetails", viewModel);
			});
		}

	}

}