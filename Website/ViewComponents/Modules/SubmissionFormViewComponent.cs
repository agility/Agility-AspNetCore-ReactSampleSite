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
	public class FormSubmission : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_SubmissionForm module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				string componentName = $"Components.{module.ComponentName}";

				return new ReactViewComponentResult(componentName, module.ToFrontendProps())
				{
					ClientOnly = true
				};
			});
		}

	}

}