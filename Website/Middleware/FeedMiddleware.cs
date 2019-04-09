using Agility.Web;
using Agility.Web.Objects;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Website.AgilityModels;
using Website.Extensions;

namespace Website.Middleware
{
	public class FeedMiddleware
	{

		protected readonly RequestDelegate _next;

		public FeedMiddleware(RequestDelegate next)
		{
			this._next = next;
		}

		public IHostingEnvironment HostingEnvironment { get; set; }

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

		private async Task<string> GenerateResponse(HttpContext context)
		{
			HttpRequest Request = context.Request;
			HttpResponse Response = context.Response;

			try
			{

				var postRepo = new AgilityContentRepository<BlogPost>("BlogPosts");

				var posts = postRepo
						.Items(rowFilter: null, sort: null, take: 50, skip: 0);

				var lastUpdate = posts.Max(p => p.Date);


				SyndicationFeed feed = new SyndicationFeed(
					"Agility Blog",
					$"Copyright Agility {DateTime.Now.Year}",
					new Uri("https://agilitycms.com"),
					"https://agilitycms.com/posts.xml",
					new DateTimeOffset(lastUpdate));

				feed.ImageUrl = new Uri("https://static.agilitycms.com/favicon/favicon-128.png");
				feed.Links.Add(new SyndicationLink(
					new Uri("https://agilitycms.com/posts.xml")
				));

				//feed.Authors.Add(new SyndicationPerson("someone@microsoft.com"));
				feed.Categories.Add(new SyndicationCategory("News"));
				feed.Categories.Add(new SyndicationCategory("Blog"));


				//feed.Description = new TextSyndicationContent("This is a sample that illistrates how to expose a feed using ATOM with WCF");

				List<SyndicationItem> items = new List<SyndicationItem>();

				foreach (BlogPost post in posts)
				{

					string url = post.ResolveDynamicPageItemUrl();
					UriBuilder ub = new UriBuilder(Request.Scheme, Request.Host.Host, Request.Host.Port.GetValueOrDefault(), url);

					UriBuilder ub2 = new UriBuilder(Request.Scheme, Request.Host.Host,
						Request.Host.Port.GetValueOrDefault(),
						$"/resources/posts/post-details?ContentID={post.ContentID}");


					// Create item
					var item = new SyndicationItem(
						post.Title,
						post.Excerpt,
						ub.Uri,
						ub2.Uri.ToString(),
						post.Date
					);



					if (post.PostImage != null)
					{

						var contentType = "image/jpeg";
						if (post.PostImage.URL.EndsWith(".png", StringComparison.CurrentCultureIgnoreCase))
						{
							contentType = "image/png";
						}

						item.Links.Add(SyndicationLink.CreateMediaEnclosureLink(
							new Uri(post.PostImage.URL),
							contentType,
							0));
					}



					// if (!string.IsNullOrWhiteSpace(post.CategoriesTitle))
					// {
					// 	item.AddCategory(new SyndicationCategory(post.CategoriesTitle));
					// }

					//item.AddCategory(new SyndicationCategory(post.));
					if (post.AuthorID > 0)
					{
						var author = post.Author.GetByID(post.AuthorID);
						if (author != null)
						{
							item.Authors.Add(new SyndicationPerson(null, author.Title, null));
						}
					}

					items.Add(item);

				}


				feed.Items = items;

				var atomFeed = new Atom10FeedFormatter(feed);

				Encoding utf8noBOM = new UTF8Encoding(false);

				using (StringWriter sw = new StringWriterWithEncoding(utf8noBOM))
				{

					using (XmlWriter xmlWriter = XmlWriter.Create(sw, new XmlWriterSettings()
					{
						Async = true,
						Indent = true,
						Encoding = utf8noBOM
					}))
					{
						atomFeed.WriteTo(xmlWriter);

						// var writer = new Microsoft.SyndicationFeed.Rss.RssFeedWriter(xmlWriter);

						// await writer.WriteTitle("Agility Blog");
						// await writer.WriteCopyright($"Copyright Agility {DateTime.Now.Year}");

						// foreach (BlogPost post in posts)
						// {

						// 	// Create item
						// 	var item = new SyndicationItem()
						// 	{
						// 		Title = post.Title,
						// 		Description = post.Excerpt,
						// 		Id = $"{post.ContentID}",
						// 		Published = post.Date
						// 	};
						// 	string url = post.ResolveDynamicPageItemUrl();


						// 	UriBuilder ub = new UriBuilder(Request.Scheme, Request.Host.Host, Request.Host.Port.GetValueOrDefault(80), url);

						// 	item.AddLink(new SyndicationLink(ub.Uri));


						// 	if (post.PostImage != null)
						// 	{
						// 		item.AddLink(new SyndicationImage(new Uri(post.PostImage.URL));

						// 	}



						// 	if (!string.IsNullOrWhiteSpace(post.CategoriesTitle))
						// 	{
						// 		item.AddCategory(new SyndicationCategory(post.CategoriesTitle));
						// 	}

						// 	//item.AddCategory(new SyndicationCategory(post.));
						// 	if (post.AuthorID > 0)
						// 	{
						// 		var author = post.Author.GetByID(post.AuthorID);
						// 		if (author != null)
						// 		{
						// 			item.AddContributor(new SyndicationPerson(author.Title, author.Title));
						// 		}
						// 	}

						// 	await writer.Write(item);

						//}


						xmlWriter.Flush();
					}

					return sw.ToString();
				}
			}
			catch (Exception ex)
			{
				return ex.ToString();
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

	public sealed class StringWriterWithEncoding : StringWriter
	{
		private readonly Encoding encoding;

		public StringWriterWithEncoding() { }

		public StringWriterWithEncoding(Encoding encoding)
		{
			this.encoding = encoding;
		}

		public override Encoding Encoding
		{
			get { return encoding; }
		}
	}

	public static class RSSExtensions
	{
		public static IApplicationBuilder UseFeedHandler(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<FeedMiddleware>();
		}
	}
}