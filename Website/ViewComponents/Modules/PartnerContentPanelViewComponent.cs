using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;
using Agility.Web;

namespace Website.ViewComponents.Modules
{
	public class PartnerContentPanel : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_PartnerContentPanel module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var partner = Agility.Web.AgilityContext.GetDynamicPageItem<Partner>();

				if (partner == null)
					throw new ArgumentNullException("Partner");

				var partnerFront = partner.ToFrontendProps();

				var viewModel = new
				{
					ImagePosition = partnerFront.ImagePosition,
					Image = partnerFront.Image,
					//StudyImage = partnerFront.CustomerLogo,
					Title = partnerFront.Title,
					ContentPanelCopy = partnerFront.ContentPanelCopy,
					fgColor = partnerFront.BrandFGColor,
					bgColor = partnerFront.BrandBGColor
				};

				return new ReactViewComponentResult("Components.PartnerContentPanel", viewModel);
			});
		}

	}

}