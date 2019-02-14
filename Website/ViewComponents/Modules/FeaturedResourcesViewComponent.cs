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
	public class FeaturedResources : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_FeaturedResources module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var viewModel = new
				{
					title = module.Title,
					subTitle = module.SubTitle,
					readMoreLabel = module.ReadMoreLabel,
					items = module.Resources.GetByIDs(module.IDs).Select(p => p.GetListingViewModel())
				};

				return new ReactViewComponentResult("Components.FeaturedResources", viewModel);

			});
		}

	}

}