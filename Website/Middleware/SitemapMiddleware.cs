using Agility.Web;
using Agility.Web.Objects;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Website.Middleware
{
	public class SitemapMiddleware
	{

		protected readonly RequestDelegate _next;

		public SitemapMiddleware(RequestDelegate next)
		{
			this._next = next;
		}

		public IHostingEnvironment HostingEnvironment { get; set; }

		private const string XMLNSAttribute = "http://www.sitemaps.org/schemas/sitemap/0.9";
		private const string XMLNSImageAttribute = "http://www.google.com/schemas/sitemap-image/1.1";

		public async Task Invoke(HttpContext context, IHostingEnvironment env)
		{
			HostingEnvironment = env;

			string response = await Task.Run<string>(() =>
			{
				return GenerateResponse(context);
			});

			context.Response.ContentType = "text/xml";

			await context.Response.WriteAsync(response);

		}

		private string GenerateResponse(HttpContext context)
		{
			HttpRequest Request = context.Request;
			HttpResponse Response = context.Response;



			using (StringWriter sw = new StringWriter())
			{
				using (XmlTextWriter writer = new XmlTextWriter(sw))
				{
					writer.Formatting = Formatting.Indented;

					writer.WriteRaw("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
					// write out <PromoItem>s
					writer.WriteStartElement("urlset");
					writer.WriteAttributeString("xmlns", XMLNSAttribute);
					writer.WriteAttributeString("xmlns:image", XMLNSImageAttribute);
					// write elements

					BuildSiteMap(context, writer);

					// write out </PromoItems>
					writer.WriteEndElement();

					writer.Close();

					return sw.ToString();
				}
			}
		}

		protected virtual void BuildSiteMap(HttpContext context, XmlTextWriter writer)
		{
			//Loops through All Languages
			string startingLanguage = Agility.Web.AgilityContext.LanguageCode;
			Agility.Web.Objects.Language[] langs = Agility.Web.AgilityContext.Domain.Languages;


			var channel = AgilityContext.CurrentChannel;

			foreach (Agility.Web.Objects.Language l in langs)
			{

				var channelDomain = channel.Domains.FirstOrDefault(d =>
					string.Equals(d.DefaultLanguage, l.LanguageCode, StringComparison.CurrentCultureIgnoreCase)
					&& d.ForceDefaultLanguageToThisDomain);

				Agility.Web.AgilityContext.LanguageCode = l.LanguageCode;

				var sitemap = AgilityContext.AgilitySiteMap;

				foreach (var oNode in sitemap.RootNode.ChildNodes)
				{

					WriteURLNode(context, writer, l.LanguageCode, oNode, channelDomain);
				}
			}

			Agility.Web.AgilityContext.LanguageCode = startingLanguage;
		}



		protected virtual void WriteURLNode(HttpContext context, XmlTextWriter writer, string langCode, AgilitySiteMapNode node, ChannelDomain channelDomain)
		{
			//skip stuff that doesn't belong on the sitemap...
			if (!node.SitemapVisible)
			{
				return;
			}

			string host = null;
			if (channelDomain == null)
			{
				//no default domain per language... 
				host = context.Request.GetDisplayUrl();
				host = host.Substring(0, host.IndexOf("/", host.IndexOf("://") + 3));
			}
			else
			{
				host = channelDomain.URL.TrimEnd('/');

			}

			string loc = node.Url.ToLowerInvariant();
			if (loc.EndsWith(".aspx"))
			{
				loc = loc.Substring(0, loc.LastIndexOf(".aspx"));
			}

			DateTime lastMod = DateTime.MinValue;
			string changeFreq = "daily";
			double priority = 0;

			Agility.Web.Objects.AgilitySiteMapNode agilityNode = node as Agility.Web.Objects.AgilitySiteMapNode;
			Agility.Web.Objects.AgilityDynamicSiteMapNode dynamicNode = node as Agility.Web.Objects.AgilityDynamicSiteMapNode;

			if (loc == "~/home" || loc == "~/default")
			{
				//home page
				loc = "/";
				changeFreq = "daily";

				//home page has highest priority
				priority = 1.0;

			}
			else if (dynamicNode != null)
			{
				//get the item that this page represents and use the last mod of it...
				AgilityContentRepository<AgilityContentItem> content = new AgilityContentRepository<AgilityContentItem>(dynamicNode.ReferenceName);
				AgilityContentItem item = content.Item(string.Format("ContentID = {0}", dynamicNode.ContentID));
				lastMod = item.ModifiedDate;
				priority = 0;

			}
			else if (agilityNode != null)
			{
				if (agilityNode.AgilityPage != null)
				{
					foreach (var section in agilityNode.AgilityPage.ContentSections)
					{
						AgilityContentRepository<AgilityContentItem> content = new AgilityContentRepository<AgilityContentItem>(section.ContentReferenceName);
						var item = content.Items().FirstOrDefault();

						if (item != null && item.ModifiedDate > lastMod) lastMod = item.ModifiedDate;

					}
				}
			}

			do
			{
				if (loc.Contains("javascript:"))
				{
					break;
				}

				//check if the location is absolute and part of a different domain...
				if (loc.StartsWith("http"))
				{
					Uri url = new Uri(loc);
					if (url.Host != host) break;
				}

				writer.WriteStartElement("url");
				if (!string.IsNullOrEmpty(loc))
				{
					writer.WriteStartElement("loc");

					if (loc.StartsWith("http"))
					{
						writer.WriteString(loc);
					}
					else
					{
						writer.WriteString(string.Format("{0}{1}", host, ResolveUrl(loc).ToLowerInvariant()));
					}
					writer.WriteEndElement();
				}

				/*
				* This was removed due to potential performance issues with sites that had alot of articles
				* 
				if (images.Any())
				{
					foreach(var image in images)
					{
						writer.WriteStartElement("image:image");
						
						writer.WriteStartElement("image:loc");
						writer.WriteString(image.Loc);
						writer.WriteEndElement();

						if (!string.IsNullOrEmpty(image.Title))
						{
							writer.WriteStartElement("image:title");
							writer.WriteString(image.Title);
							writer.WriteEndElement();
						}

						if (!string.IsNullOrEmpty(image.Caption))
						{
							writer.WriteStartElement("image:caption");
							writer.WriteString(image.Caption);
							writer.WriteEndElement();
						}

						writer.WriteEndElement();

					}
				}*/

				if (lastMod > DateTime.MinValue)
				{
					writer.WriteStartElement("lastmod");
					writer.WriteString(lastMod.ToUniversalTime().ToString("u").Replace(" ", "T"));
					writer.WriteEndElement();


					if (loc == "/")
					{

					}
					else
					{
						//subtract a tenth for each 

						int weeks = (int)Math.Floor((DateTime.Now - lastMod).TotalDays / 7);

						priority = 1.0 - (weeks / .1);
						if (priority < 0) priority = 0;
					}
				}

				if (priority > 0)
				{
					writer.WriteStartElement("priority");
					writer.WriteString(priority.ToString("F1"));
					writer.WriteEndElement();
				}

				if (!string.IsNullOrEmpty(changeFreq))
				{
					writer.WriteStartElement("changefreq");
					writer.WriteString(changeFreq);
					writer.WriteEndElement();
				}


				writer.WriteEndElement();
			} while (false);

			var children = AgilityContext.AgilitySiteMap.GetChildNodes(node);


			//loop all the child elements..
			foreach (var child in children)
			{
				WriteURLNode(context, writer, langCode, child, channelDomain);
			}
		}

		protected string ResolveUrl(string relativeUrl)
		{

			//replace the ~/
			if (relativeUrl.StartsWith("~/"))
			{

				string appPath = "/";
				if (appPath.EndsWith("/")) return string.Format("{0}{1}", appPath, relativeUrl.Substring(2));
				return string.Format("{0}{1}", appPath, relativeUrl.Substring(1));

			}

			return relativeUrl;
		}

	}

	public static class SitemapExtensions
	{
		public static IApplicationBuilder UseSitemapHandler(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<SitemapMiddleware>();
		}
	}
}