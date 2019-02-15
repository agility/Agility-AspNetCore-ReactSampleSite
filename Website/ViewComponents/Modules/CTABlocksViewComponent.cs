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
	public class CTABlocks : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_CTABlocks module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				return new ReactViewComponentResult("Components.CtaBlocks",
					new
					{
						heading = module.Heading,
						subHeading = module.SubHeading,
						items = module.CTABlocks.Items().Select(i => i.ToFrontendProps())
					}
				);
			});
		}

	}

}