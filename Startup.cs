using IMSProject.Data;
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
using DinkToPdf;
using DinkToPdf.Contracts;
using System.IO;

namespace IMSProject
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
            services.AddControllersWithViews();
            // Register DatabaseHelper and pass the Configuration
            services.AddScoped<DatabaseHelper>(sp =>
                new DatabaseHelper(Configuration.GetConnectionString("IMSConnection")));

            //services.AddRotativa(options => options.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));

            // Path to the wkhtmltopdf executable (set this to the correct path on your machine)
            // var rotativaPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Rotativa");

            //services.AddRotativa(options => options.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));


            // services.AddSingleton<IConverter, BasicConverter>();

            services.AddDistributedMemoryCache();

            // Add session services
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
                options.Cookie.HttpOnly = true; // Make the session cookie HTTP-only
                options.Cookie.IsEssential = true; // Mark the session cookie as essential
            });

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

            // Enable session middleware
            app.UseSession();


            app.UseRouting();
            //  app.MapControllers();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Users}/{action=Login}/{id?}");
            });
        }
    }
}
