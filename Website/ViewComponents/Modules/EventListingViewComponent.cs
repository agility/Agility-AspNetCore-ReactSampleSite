using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.AgilityModels;
using Website.Extensions;
using Agility.Web.Extensions;

namespace Website.ViewComponents.Modules
{
    public class EventListing: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync(Module_EventListing module) 
        {
            return Task.Run<IViewComponentResult>(() =>
            {

                string filter = "";

                if(module.ShowPastEventsOnly) {
                    //only show past events
                    filter = $"Date < '{DateTime.Now.AddDays(1)}'";
                } else {
                    filter = $"Date > '{DateTime.Now.AddDays(-1)}'";
                }

                if(module.FilterByType.GetByID(module.FilterByTypeID) != null) {
                    //we have a filter type
                    filter = $"{filter} AND EventTypeID = {module.FilterByTypeID}";
                }

                var events = module.Events.Items(filter).Select(i => new { 
                    Title = i.Title,
                    SubTitle = i.SubTitle,
                    Organizer = (i.Organizer.GetByID(i.OrganizerID) != null ? i.Organizer.GetByID(i.OrganizerID).ToFrontendProps() : null),
                    Address = i.Address,
                    Date = i.Date,
                    Thumbnail = i.Thumbnail,
                    ExternalLink = i.ExternalLink,
                    Description = i.Description
                }.ToFrontendProps());

                var viewModel = new {
                    Title = module.Title,
                    SubTitle = module.SubTitle,
                    Items = events,
                    ViewDetailsLabel = module.ViewDetailsLabel,
                    BackLabel = module.BackLabel,
                    RegisterLabel = module.RegisterLabel
                };

                return new ReactViewComponentResult("Components.EventListing", viewModel) {
                    ClientOnly = true
                };
            });
        }

    }

}