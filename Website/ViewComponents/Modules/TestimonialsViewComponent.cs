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
	public class Testimonials : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_Testimonials module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var model = new
				{
					testimonials = module.Testimonials.GetByIDs(module.TestimonialIDs).Select(t => t.ToFrontendProps()),
					header = module.Header,
					subHeading = module.SubHeading,
					bottomlink = module.ParseUrl("BottomLink")
				};

				return new ReactViewComponentResult("Components.Testimonials", model);
			});
		}

	}

}