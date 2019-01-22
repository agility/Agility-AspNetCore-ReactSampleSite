using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.ViewModels;
using Website.AgilityModels;
using Agility.Web.Extensions;
using Agility.Web;

namespace Website.ViewComponents.Shared
{
	public class Header : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync()
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var repo = new AgilityContentRepository<GlobalHeader>("GlobalHeader");
				var viewModel = repo.Item(null);
				return new ReactViewComponentResult("Components.Header", viewModel);
			});
		}

	}

}