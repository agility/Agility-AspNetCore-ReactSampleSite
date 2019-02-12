using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Modules
{
    public class CTABlocks: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync() 
        {
            return Task.Run<IViewComponentResult>(() =>
            {
                var viewModel = new { Title = "test"};
                return new ReactViewComponentResult("Components.Blank", viewModel);
            });
        }

    }

}