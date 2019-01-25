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
	public class PostListing : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_PostListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				List<object> posts = new List<object>();
				var authorRepo = new AgilityContentRepository<BlogAuthor>("BlogAuthors");

				var postItems = module.Posts.Items(rowFilter: null, sort: null, take: module.PostCount, skip: 0);
				foreach (var item in postItems)
				{

					DynamicPageItem dp = Data.GetDynamicPageItem("~/posts/post-details", module.Posts.ContentReferenceName, item.Row);
					string url = $"/posts/{dp.Name}";

					var image = item.ListingImageOverride != null ? item.ListingImageOverride : item.PostImage;
					var author = authorRepo.GetByID(item.AuthorID);

					posts.Add(new
					{
						title = dp.Title,
						excerpt = item.Excerpt,
						date = item.Date.ToString("yyyy/MM/dd"),
						author = author == null ? "Agility" : author.Title,
						url = url,
						image = new
						{
							alt = image.Label,
							srcSmall = $"{image.URL}?q=65&w=100",
							srcMedium = $"{image.URL}?q=65&w=300",
							srcLarge = $"{image.URL}?q=65&w=500"
						}

					});

				}

				var viewModel = new
				{
					posts = posts
				};


				return new ReactViewComponentResult("Components.PostListing", viewModel);
			});
		}

	}

}