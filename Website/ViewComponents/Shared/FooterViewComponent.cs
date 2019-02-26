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
	public class Footer : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync()
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var repo = new AgilityContentRepository<GlobalFooter>("GlobalFooter");
				GlobalFooter item = repo.Item(null);


				var viewModel = new
				{
					column1Title = item.Column1Title,
					column2Title = item.Column2Title,
					column3Title = item.Column3Title,
					column1Links = item.Column1Links.SortByIDs(item.Column1SortIDs).Select(a => a.ToFrontendProps()),
					column2Links = item.Column2Links.SortByIDs(item.Column2SortIDs).Select(a => a.ToFrontendProps()),
					column3Links = item.Column3Links.SortByIDs(item.Column3SortIDs).Select(a => a.ToFrontendProps()),
					followTitle = item.FollowTitle,
					//followLinks = item.FollowLinks.SortByIDs(item.FollowLinkIDs).Select(a => a.ToFrontendProps()),
					subscribeTitle = item.SubscribeTitle,
					subscribeButtonLabel = item.SubscribeButtonLabel,
					subscribeDescription = item.SubscribeDescription,
					subscribeEmailPlaceholder = item.SubscribeEmailPlaceholder,
					subscribePOSTUrl = item.SubscribePOSTUrl,
					subscribeRedirect = item.SubscribeRedirect,
					bottomLinks = item.BottomLinks.SortByIDs(item.BottomLinksSortIDs).Select(a => a.ToFrontendProps()),
					bottomCopyright = item.Copyright
				};


				return new ReactViewComponentResult("Components.Footer", viewModel);
			});
		}

	}

}