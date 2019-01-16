using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.ViewModels;
using Website.AgilityModels;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Shared
{
    public class Header: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync() 
        {
            return Task.Run<IViewComponentResult>(() =>
            {
                var viewModel = new { test = "nothing"};
                return new ReactViewComponentResult("Components.Header", viewModel);
            });
        }

    }

}