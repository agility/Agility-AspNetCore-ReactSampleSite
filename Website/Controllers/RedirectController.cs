using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
	public class RedirectController : Controller
	{
		public IActionResult BlogPost(string category, string url)
		{
			return Redirect($"/posts/{url}");
		}
	}
}
