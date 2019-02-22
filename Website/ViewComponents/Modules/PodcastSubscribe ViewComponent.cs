using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;
using Agility.Web;
using System.Web;

namespace Website.ViewComponents.Modules
{
	public class PodcastSubscribe : ViewComponent
	{
		public Task<IViewComponentResult> InvokeAsync(Module_PodcastSubscribe module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{



				var items = module.PodcastPlatforms.Items()
									   .Select(r => new
									   {
										   title = r.Title,
										   image = r.Logo.ToFrontendProps(),
										   url = r.ParseUrl("FollowURL"),
										   key = r.ContentID
									   });

				var viewmodel = new
				{
					title = module.Title,
					items = items
				};

				return new ReactViewComponentResult("Components.ListenToPodcast", viewmodel);
			});
		}

	}

}