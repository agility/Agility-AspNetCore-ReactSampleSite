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
	public class ResourceDetails : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_ResourceDetails module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var resource = Agility.Web.AgilityContext.GetDynamicPageItem<Resource>();

				var currentPage = AgilityContext.Page;

				ResourceType resourceType = null;
				BlogAuthor author = null;

				if (resource.AuthorID > 0)
				{
					author = resource.Author.GetByID(resource.AuthorID);
				}

				if (resource.ResourceTypeID > 0)
				{
					resourceType = resource.ResourceType.GetByID(resource.ResourceTypeID);
				}


				string description = currentPage.MetaTags;
				if (string.IsNullOrWhiteSpace(description))
				{
					description = resource.Excerpt.Truncate(300, "...", true, true).Replace("\"", "&quot;");
					currentPage.MetaTags = description;
				}

				string canonicalUrl = Request.GetEncodedUrl();
				if (canonicalUrl.Contains("?")) canonicalUrl = canonicalUrl.Substring(0, canonicalUrl.IndexOf("?"));

				currentPage.MetaTagsRaw = Utils.SEOUtils.GetRawMetaTags(
					existingRawTags: currentPage.MetaTagsRaw,
					title: resource.Title,
					canonicalUrl: canonicalUrl,
					category: resourceType?.Title,
					description: description,
					image: resource.Image
				);


				var viewModel = new
				{

					resource = resource.ToFrontendProps(),
					author = author,
					resourceType = resourceType
				};


				return new ReactViewComponentResult("Components.ResourceDetails", viewModel);
			});
		}

	}

}