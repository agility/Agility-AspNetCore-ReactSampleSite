﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Agility.Web;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Website.AgilityModels;
using Website.Models;

namespace Website.Controllers
{
    public class ListingController : Controller
    {

        public IActionResult Posts(int skip, int take)
        {

            var postRepo = new AgilityContentRepository<BlogPost>("BlogPosts");

            var posts = postRepo
                    .Items(rowFilter: null, sort: null, take: take, skip: skip)
                    .Select(p => p.GetListingViewModel());

            var viewModel = new
            {
                posts = posts,
                skip = skip,
                take = take
            };

            return Json(viewModel);
        }

        public IActionResult CaseStudies(int skip, int take)
        {

            var caseStudyRepo = new AgilityContentRepository<CaseStudy>("CaseStudies");

            var caseStudies = caseStudyRepo
                    .Items(rowFilter: null, sort: null, take: take, skip: skip)
                    .Select(p => p.GetListingViewModel());

            var viewModel = new
            {
                posts = caseStudies,
                skip = skip,
                take = take
            };

            return Json(viewModel);
        }

        public IActionResult Resources(string ids = null, int skip = 0, int take = 100)
        {

            var repo = new AgilityContentRepository<Resource>("Resources");
            string filter = null;
            if (!string.IsNullOrWhiteSpace(ids))
            {
                filter = $"ResourceTypeID in ({ids})";
            }

            var items = repo
                    .Items(rowFilter: filter, sort: "ItemOrder", take: take, skip: skip)
                    .Select(p => p.GetListingViewModel());

            var viewModel = new
            {
                items = items,
                skip = skip,
                take = take,
                ids = ids
            };

            return Json(viewModel);
        }

        public IActionResult Partners(string refName, string labelIDs, string ids = null, int skip = 0, int take = 100)
        {


            var repo = new AgilityContentRepository<Partner>(refName);
            var items = repo.Items().AsQueryable();
            if (!string.IsNullOrWhiteSpace(ids))
            {
                string[] lstIds = ids.Split(',');
                items = items.Where(l => l.MatchesWith(lstIds));
            }

            if (skip > 0) items = items.Skip(skip);
            if (take > 0) items = items.Take(take);

            var viewModel = new
            {
                items = items.Select(l => l.GetPartnerListingViewModel(labelIDs)),
                skip = skip,
                take = take,
                ids = ids
            };

            return Json(viewModel);
        }

        public IActionResult Features(string refName, string labelIDs, string ids = null, int skip = 0, int take = 100)
        {
            var repo = new AgilityContentRepository<FeatureBlock>(refName);
            var items = repo.Items().AsQueryable();
            if (!string.IsNullOrWhiteSpace(ids))
            {
                string[] lstIds = ids.Split(',');
                items = items.Where(l => l.MatchesWith(lstIds));
            }

            if (skip > 0) items = items.Skip(skip);
            if (take > 0) items = items.Take(take);

            var viewModel = new
            {
                items = items.Select(l => l.GetFeatureListingViewModel(labelIDs)),
                skip = skip,
                take = take,
                ids = ids
            };

            return Json(viewModel);
        }

		
        public IActionResult Podcasts(string refName, string sortBy, int skip, int take)
        {
            var repo = new AgilityContentRepository<Podcast>(refName);

			var podcasts = repo.Items(rowFilter: null, sort: sortBy, take: take, skip: skip)
					.Select(p => p.GetListingViewModel(240));

			return Json(new {
				podcasts
			});
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
