using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Website.Middleware
{
	public class RobotsMiddleware
	{

		private readonly RequestDelegate _next;

		public RobotsMiddleware(RequestDelegate next)
		{
			this._next = next;
		}

		public IHostingEnvironment HostingEnvironment { get; set; }


		public async Task Invoke(HttpContext context, IHostingEnvironment env)
		{
			HostingEnvironment = env;
			string response = await GenerateResponse(context);

			if (string.IsNullOrWhiteSpace(response))
			{
				await _next.Invoke(context);

			}
			else
			{
				context.Response.ContentType = GetContentType();
				await context.Response.WriteAsync(response);
			}
		}

		private async Task<string> GenerateResponse(HttpContext context)
		{
			HttpRequest Request = context.Request;
			HttpResponse Response = context.Response;

			//check if this is Robots.txt and a publishwithagility.com domain (used for staging only)
			if (Request.Host.Value.IndexOf(".azurewebsites.net", StringComparison.CurrentCultureIgnoreCase) != -1)
			{
				StringBuilder sb = new StringBuilder();
				sb.AppendLine("User-agent: *");
				sb.Append("Disallow: /");
				return sb.ToString();
			}
			else
			{
				//grab the robots file text and output that...
				string filepath = System.IO.Path.Combine(HostingEnvironment.WebRootPath, "robots.txt");
				if (System.IO.File.Exists(filepath))
				{
					return await System.IO.File.ReadAllTextAsync(filepath);
				}
			}

			return null;


		}

		private string GetContentType()
		{
			return "text/plain";
		}
	}

	public static class RobotsExtensions
	{
		public static IApplicationBuilder UseRobotsHandler(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<RobotsMiddleware>();
		}
	}
}