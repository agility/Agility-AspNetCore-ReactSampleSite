using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.AgilityModels;
using System.Linq;
using Website.Extensions;

namespace Website.ViewComponents.Modules
{
    public class Callout: ViewComponent
    {
        
        public Task<IViewComponentResult> InvokeAsync(Module_Callout module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				var callout = module.Callout.GetByID(module.CalloutID).ToFrontendProps();

				var viewModel = new {
					Theme = module.Theme,
					Title = callout.Title,
					Caption = callout.Caption,
					Link = callout.Link
				};

				return new ReactViewComponentResult("Components.Callout", viewModel);
			});
		}
    }
}