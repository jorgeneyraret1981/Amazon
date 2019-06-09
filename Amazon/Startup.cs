/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders; */
using Microsoft.Extensions.Configuration;
using Amazon.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Amazon
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*  services.Configure<CookiePolicyOptions>(options =>
              {
                  // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                  options.CheckConsentNeeded = context => true;
                  options.MinimumSameSitePolicy = SameSiteMode.None;
              });


              services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
              */

            services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(
                Configuration["Data:AmazonStoreDB:ConnectionString"]));



            services.AddTransient<IBookRepository, EFBookRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            /*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStaticFiles(new StaticFileOptions()
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                    RequestPath = new PathString("/vendor")
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");
                          //      CONTROLADOR HOME DE CARPETA CONTROLERS Y ACCION INDEX U OTRO 
                  // template: "{controller=Home}/{action=About}/{id?}");
            });
            */


            SeedData.EnsurePopulated(app);

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                RequestPath = new PathString("/vendor")
            });

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                name: null,
                template: "{category}/Page{bookPage:int}",
                defaults: new { controller = "Book", action = "List" });
                routes.MapRoute(
                name: null,
                template: "Page{bookPage:int}",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });
                routes.MapRoute(
                name: null,
                template: "{category}",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });
                routes.MapRoute(
                name: null,
                template: "",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });
                routes.MapRoute(
                name: null,
                template: "{controller}/{action}/{id?}");
            });
        }
    }
}
