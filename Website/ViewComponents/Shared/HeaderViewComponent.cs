using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
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
				var item = repo.Item(null);

				var viewModel = new
				{
					logo = item.Logo,
					preHeaderLinks = item.PreHeaderLinks.SortByIDs(item.PreHeaderLinkSortIDs).Select(a => a.ToFrontendProps()),
					primaryButton = item.ParseUrl("PrimaryButton")
				};

				return new ReactViewComponentResult("Components.Header", viewModel);
			});
		}

	}

}