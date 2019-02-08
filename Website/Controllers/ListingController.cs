using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Agility.Web;
using Microsoft.AspNetCore.Mvc;
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

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
