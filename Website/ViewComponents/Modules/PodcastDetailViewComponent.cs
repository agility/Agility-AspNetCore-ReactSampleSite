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
	public class PodcastDetail : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_PodcastDetail module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var post = Agility.Web.AgilityContext.GetDynamicPageItem<Podcast>();
				var currentPage = AgilityContext.Page;

				var viewModel = post.ToFrontendProps();

				string description = currentPage.MetaTags;
				if (string.IsNullOrWhiteSpace(description))
				{
					description = post.Excerpt.Truncate(240, "...", true, true).Replace("\"", "&quot;");
					currentPage.MetaTags = description;
				}

				string canonicalUrl = Request.GetEncodedUrl();
				if (canonicalUrl.Contains("?")) canonicalUrl = canonicalUrl.Substring(0, canonicalUrl.IndexOf("?"));

				currentPage.MetaTagsRaw = Utils.SEOUtils.GetRawMetaTags(
					existingRawTags: currentPage.MetaTagsRaw,
					title: post.Title,
					canonicalUrl: canonicalUrl,
					category: "Podcast",
					description: description,
					image: post.MainImage
				);

				return new ReactViewComponentResult("Components.PodcastDetails", viewModel);
			});
		}

	}

}