using INTEXPractice.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.ML.OnnxRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEXPractice
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

            services.AddDbContext<CrashesDbContext>(options =>
            {
                options.UseMySql(Configuration["ConnectionString:AccidentsDbConnection"]);
            });

            services.AddSingleton<InferenceSession>(
            new InferenceSession("INTEX2_7.onnx"));

            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddServerSideBlazor();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //endpoints.MapControllerRoute("typePage",
            //    "{category}/Page{pageNum}",
            //    new { Controller = "Home", action = "Index" });

            //endpoints.MapControllerRoute("Paging",
            //    "Page{pageNum}",
            //    new { Controller = "Home", action = "Index", pageNum = 1 });

            //endpoints.MapControllerRoute("type",
            //    "{category}",
            //    new { Controller = "Home", action = "Index", pageNum = 1 });

            //endpoints.MapDefaultControllerRoute();

            //endpoints.MapRazorPages();

            //endpoints.MapBlazorHub();
            //endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");
        }
    }
}