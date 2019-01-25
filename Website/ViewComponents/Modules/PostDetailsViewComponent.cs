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
	public class PostDetails : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_PostDetails module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var post = Agility.Web.AgilityContext.GetDynamicPageItem<BlogPost>();

				var viewModel = new
				{
					categoryLabel = module.CategoryLabel,
					relatedPostsLabel = module.RelatedPostsLabel,
					relatedPostsCount = module.RelatedPostsCount,
					post = post.ToFrontendProps()
				};


				return new ReactViewComponentResult("Components.PostDetails", viewModel);
			});
		}

	}

}