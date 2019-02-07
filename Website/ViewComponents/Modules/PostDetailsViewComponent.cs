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

				BlogCategory category = null;
				BlogAuthor author = null;

				if (post.AuthorID > 0)
				{
					author = post.Author.GetByID(post.AuthorID);
				}

				if (!string.IsNullOrWhiteSpace(post.CategoriesIDs))
				{
					var cats = post.Categories.GetByIDs(post.CategoriesIDs);
					if (cats.Count > 0) category = cats[0];
				}


				string description = currentPage.MetaTags;
				if (string.IsNullOrWhiteSpace(description))
				{
					description = post.Excerpt.Truncate(300, "...", true, true).Replace("\"", "&quot;");
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

				var viewModel = new
				{
					categoryLabel = module.CategoryLabel,
					relatedPostsLabel = module.RelatedPostsLabel,
					relatedPostsCount = module.RelatedPostsCount,
					post = post.ToFrontendProps(),
					category = category.ToFrontendProps(),
					author = author.ToFrontendProps()
				};

				return new ReactViewComponentResult("Components.PostDetails", viewModel);
			});
		}

	}

}