using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;
using Agility.Web;
using Agility.Web.Objects;

namespace Website.ViewComponents.Shared
{
	public class Header : ViewComponent
	{

		private dynamic GetChildNodes(AgilitySiteMapNode node, int level)
		{
			if (level > 1) return null;
			++level;
			return from topNode in node.ChildNodes
				   where topNode.MenuVisible && string.IsNullOrWhiteSpace(topNode.DynamicPageContentReferenceName)
				   select new
				   {
					   key = topNode.PageItemID,
					   text = topNode.Title,
					   url = Agility.Web.Util.Url.ResolveTildaUrlsInHtml(topNode.Url),
					   target = topNode.Target,
					   children = GetChildNodes(topNode, level)
				   };
		}
		public Task<IViewComponentResult> InvokeAsync()
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var repo = new AgilityContentRepository<GlobalHeader>("GlobalHeader");
				var item = repo.Item(null);

				var sitemap = AgilityContext.AgilitySiteMap;

				var topLevelNodes = GetChildNodes(sitemap.RootNode, 0);

				var viewModel = new
				{
					logo = item.Logo.ToImage(),
					mobileLogo = item.MobileLogo.ToImage(),
					preHeaderLinks = item.PreHeaderLinks.SortByIDs(item.PreHeaderLinkSortIDs).Select(a => a.ToFrontendProps()),
					preHeaderPrimaryButton = item.PreHeaderPrimaryButton.ParseUrl(),
					primaryButton = item.PrimaryButton.ParseUrl(),
					menu = topLevelNodes,
					siteSearchSettings = new AgilityContentRepository<SiteSearchSettings>("SiteSearchSettings").Item(null).ToFrontendProps()
				};

				return new ReactViewComponentResult("Components.Header", viewModel);
			});
		}

	}

}