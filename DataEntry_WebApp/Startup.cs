using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
// todo: ( 1.) add MVC namespace
using Microsoft.AspNetCore.Mvc;

namespace DataEntry_WebApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // todo: ( 2.) add support for MVC Controllers
            services.AddControllersWithViews();
            // todo: ( 3.) add Models,Controllers,Views,Views/Home,Views/Shared folders

            // todo: ( 8.) add _ViewImports file with (a) models namespace and (b) taghelpers 
            // todo: ( 9.) add _ViewStart file and Shared/_Layout.cshtml
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // todo: ( 4.) status code (400s & 500s)
                app.UseStatusCodePages();
            }
            // todo: ( 5.) static file support
            app.UseStaticFiles();
            // todo: ( 6.) add wwwroot folder

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // todo: ( 7.) map default mvc endpoint
                endpoints.MapDefaultControllerRoute();
                //.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
        }
    }
}
