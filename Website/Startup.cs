using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using React.AspNet;
using Agility.Web;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;
using Website.Middleware;
using Newtonsoft.Json.Serialization;

namespace Website
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public IServiceProvider ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddReact();

			// Make sure a JS engine is registered, or you will get an error!
			services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName)
			  .AddChakraCore();

			var assembly = typeof(Startup).GetTypeInfo().Assembly;

			services.AddMvc()
				.AddApplicationPart(assembly)
				.AddControllersAsServices()
				.AddJsonOptions(options => options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());



			AgilityContext.ConfigureServices(services, Configuration);

			// Build the intermediate service provider then return it
			return services.BuildServiceProvider();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseBrowserLink();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			//configure the Agility Context 
			AgilityContext.Configure(app, env, useResponseCaching: true);

			//custom middleware defined in this website code
			app.MapWhen(context => context.Request.Path.Value.EndsWith("robots.txt", true, null),
						appBranch => { appBranch.UseRobotsHandler(); });

			app.MapWhen(context => context.Request.Path.Value.EndsWith("sitemap.xml", true, null),
						appBranch => { appBranch.UseSitemapHandler(); });


			app.UseStaticFiles();

			app.UseMvc(routes =>
			{
				//blog post redirects
				routes.MapRoute(
					name: "BlogPostRedirect",
					template: "blog/{category}/{url}",
					defaults: new { controller = "Redirect", action = "BlogPost" }
				);

				//news redirects
				routes.MapRoute(
					name: "NewsRedirect",
					template: "news/{url}",
					defaults: new { controller = "Redirect", action = "BlogPost" }
				);

				//Agility Builtin Route
				routes.MapRoute("Agility", "{*sitemapPath}", new { controller = "Agility", action = "RenderPage" },
					new { isAgilityPath = new Agility.Web.Mvc.AgilityRouteConstraint() });



				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});

			// Initialise ReactJS.NET. Must be before static files.
			app.UseReact(config =>
			{
				config
					.SetReuseJavaScriptEngines(true) //we want to reuse engines as much as possible
					.SetLoadBabel(false) //don't load bable, our webpack will handle that
					.SetLoadReact(false) //webpack will add-in react in our build
					.SetMaxEngines(25) //default is 25 engines
					.AddScriptWithoutTransform("~/dist/server.js"); //tell our web app what JS we need to load for SSR

				// If you want to use server-side rendering of React components,
				// add all the necessary JavaScript files here. This includes
				// your components as well as all of their dependencies.
				// See http://reactjs.net/ for more information. Example:
				//config
				//  .AddScript("~/Scripts/First.jsx")
				//  .AddScript("~/Scripts/Second.jsx");

				// If you use an external build too (for example, Babel, Webpack,
				// Browserify or Gulp), you can improve performance by disabling
				// ReactJS.NET's version of Babel and loading the pre-transpiled
				// scripts. Example:
				//config
				//  .SetLoadBabel(false)
				//  .AddScriptWithoutTransform("~/Scripts/bundle.server.js");
			});
		}
	}
}
