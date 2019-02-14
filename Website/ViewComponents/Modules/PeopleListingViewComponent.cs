using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.AgilityModels;
using System.Linq;
using Website.Extensions;

namespace Website.ViewComponents.Modules
{
    public class PeopleListingViewComponent: ViewComponent
    {
        
        public Task<IViewComponentResult> InvokeAsync(Module_PeopleListing module)
		{
			return Task.Run<IViewComponentResult>(() =>
			{
				return new ReactViewComponentResult("Components.PeopleListing",  new
				{
					Title = module.Title,
					Subtitle = module.Subtitle,
                    Items = module.People.Items().Select(p => p.ToFrontendProps())
				});
			});
		}
    }
}