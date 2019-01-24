using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Agility.Web.Extensions;
using Agility.Web;
using Website.Extensions;

namespace Website.ViewComponents.Modules
{
    public class React: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync(AgilityContentItem module) 
        {
            return Task.Run<IViewComponentResult>(() =>
            {
                var contentSection = AgilityContext.Page.ContentSections.FirstOrDefault(i => i.ContentReferenceName == module.ReferenceName);
                var moduleDefinition = Data.GetModule(contentSection.ModuleID);
                string componentName = moduleDefinition.ReferenceName;
                var viewModel = module.ToFrontendProps();
                return new ReactViewComponentResult($"Components.{componentName}", viewModel);
            });
        }

    }

}