using Agility.Web;
using Agility.Web.Extensions;
using Agility.Web.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Web;
using Website.AgilityModels;
using Website.Extensions;
using Website.Models;

namespace Website.ViewModels
{
    public class LogoListingViewModel {
        public LogoListingViewModel() {}
        public LogoListingViewModel(Module_LogoListing module) {
            Heading = module.Heading;
            SubHeading = module.SubHeading;
            RenderType = module.RenderType;
            PrimaryButton = module.ParseUrl("PrimaryButton");
            SecondaryButton = module.ParseUrl("SecondaryButton");
            Logos = module.Logos.SortByIDs(module.LogoIDs).Select(p => new LogoListedItemViewModel {
                Url = p.URL.ParseUrl(),
                Image = p._Logo.ToImage()
            }).ToList();
        }

        public LogoListingViewModel(Module_PartnerLogoListing module) {
            Heading = module.Heading;
            SubHeading = module.SubHeading;
            RenderType = module.RenderType;
            PrimaryButton = module.ParseUrl("PrimaryButton");
            SecondaryButton = module.ParseUrl("SecondaryButton");
            Logos = module.Partners.GetByIDs(module.PartnersIDs).Select(p => new LogoListedItemViewModel() {
                Url = new UrlField() {
                    Text = p.Title,
                    Href = p.ResolveDynamicPageItemUrl(),
                    Target = "_self"
                },
                Image = p.PartnerLogo.ToImage()
            }).ToList();
                    
        }
        public string Heading {get;set;}
        public string SubHeading {get;set;}
        public string RenderType {get;set;}
        public UrlField PrimaryButton {get;set;}
        public UrlField SecondaryButton {get;set;}
        public List<LogoListedItemViewModel> Logos {get;set;}
    }

    public class LogoListedItemViewModel {
        public UrlField Url {get;set;}
        public Image Image {get;set;}
    }
}