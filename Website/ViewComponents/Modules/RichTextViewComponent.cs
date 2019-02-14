using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Modules
{
    public class RichText: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync(Module_RichTextArea module) 
        {
            return Task.Run<IViewComponentResult>(() =>
            {
                var viewModel = new {
                    Html = module.TextBlob
                };

                return new ReactViewComponentResult("Components.RichText", viewModel) {
                    ServerOnly = false
                };
            });
        }

    }

}