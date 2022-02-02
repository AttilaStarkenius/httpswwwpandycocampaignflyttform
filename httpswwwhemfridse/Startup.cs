using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace httpswwwhemfridse
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //// This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddControllersWithViews();
        //}

        //2.2.2022. I use website https://code-maze.com/enabling-cors-in-asp-net-core/ and change
        //from:      public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddControllersWithViews();
        //}
        //to: private readonly string _policyName = "CorsPolicy";
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddCors(opt =>
        //    {
        //opt.AddDefaultPolicy(builder =>
        //        {
        //            builder.AllowAnyOrigin()
        //                .AllowAnyHeader()
        //                .AllowAnyMethod();
        //});
        //    });
        //    services.AddControllersWithViews();
        //}
        //I think the issue is this I change in HomeController from: public IActionResult Veckostadning()
    //    {
    //        return View();
    //}
    //to:  public IActionResult WeeklyCleaning()
    //{
    //    return View();
    //}

    private readonly string _policyName = "CorsPolicy";
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(builder =>
                        {
                            builder.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                        });
            });
            services.AddControllersWithViews();
        }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
