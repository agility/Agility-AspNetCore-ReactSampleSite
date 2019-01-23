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
	public class FeatureBlocks : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_FeatureBlocks module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{

				var viewModel = new
				{
					title = module.Title,
					features = module.FeatureBlocks.GetByIDs(module.FeatureBlockIDs).Select(p => p.ToFrontendProps())
				};

				return new ReactViewComponentResult("Components.FeatureBlocks", viewModel);

			});
		}

	}

}