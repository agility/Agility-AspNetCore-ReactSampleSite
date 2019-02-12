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
	public class PostDetails : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_PostDetails module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var post = Agility.Web.AgilityContext.GetDynamicPageItem<BlogPost>();
				var currentPage = AgilityContext.Page;

				var viewModel = post.GetDetailsViewModel();

				BlogCategory category = null;

				if (!string.IsNullOrWhiteSpace(post.CategoriesIDs))
				{
					var cats = post.Categories.GetByIDs(post.CategoriesIDs);
					if (cats.Count > 0) category = cats[0];
				}

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
					category: category?.Title,
					description: description,
					image: post.PostImage
				);



				return new ReactViewComponentResult("Components.PostDetails", viewModel);
			});
		}

	}

}