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
	public class PartnerDetails : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_PartnerDetails module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var partner = Agility.Web.AgilityContext.GetDynamicPageItem<Partner>();

				if (partner == null)
					throw new ArgumentNullException();

				var currentPage = AgilityContext.Page;

				ResourceType resourceType = new ResourceType()
				{
					Title = "Partner"
				};

				string description = currentPage.MetaTags;
				if (string.IsNullOrWhiteSpace(description))
				{
					description = partner.Excerpt.Truncate(300, "...", true, true).Replace("\"", "&quot;");
					currentPage.MetaTags = description;
				}

				string canonicalUrl = Request.GetEncodedUrl();
				if (canonicalUrl.Contains("?")) canonicalUrl = canonicalUrl.Substring(0, canonicalUrl.IndexOf("?"));

				currentPage.MetaTagsRaw = Utils.SEOUtils.GetRawMetaTags(
					existingRawTags: currentPage.MetaTagsRaw,
					title: partner.Title,
					canonicalUrl: canonicalUrl,
					category: resourceType?.Title,
					description: description,
					image: partner.Image
				);

				var viewModel = new
				{
					Metrics = partner.Metrics.Items().Select(i => new
					{
						Title = i.Key,
						i.Value
					}
					),
					bgColor = partner.BrandBGColor,
					Body = partner.TextBlob,
					RightContentCopy = partner.RightContentCopy,
					Quote = partner.Quote
				};

				return new ReactViewComponentResult("Components.PartnerDetails", viewModel);
			});
		}

	}

}