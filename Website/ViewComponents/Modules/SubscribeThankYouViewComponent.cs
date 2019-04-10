using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.AgilityModels;
using System.Linq;
using Website.Extensions;

namespace Website.ViewComponents.Modules
{
	public class SubscribeThankYou : ViewComponent
	{

		public Task<IViewComponentResult> InvokeAsync(Module_SubscribedThankYou module)
		{


			return Task.Run<IViewComponentResult>(() =>
			{

				var viewModel = new
				{
					Html = module.TextBlob
				};

				if (Request.Query["subscribed"] != "true")
				{
					return Content(string.Empty);
				}


				return new ReactViewComponentResult("Components.RichText", viewModel)
				{
					ServerOnly = true
				};
			});
		}
	}
}