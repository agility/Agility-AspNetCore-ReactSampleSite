using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Modules
{
    public class Share: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync(Module_Share module) 
        {
            return Task.Run<IViewComponentResult>(() =>
            {
                var viewModel = module;
                return new ReactViewComponentResult("Components.Share", viewModel) { ClientOnly = true};
            });
        }

    }

}