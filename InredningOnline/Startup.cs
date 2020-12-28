using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InredningOnline.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InredningOnline
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
            // Connection to database InMemory or SqlServer
            var USING_SQL = true;
            services.AddDbContext<AppDbContext>(options =>
            {
                if (USING_SQL)
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

                }
                else
                {
                    options.UseInMemoryDatabase("Projects");

                }
            });

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();

            // Register my own services
            services.AddScoped<IProjectRepo, ProjectRepo>();
            services.AddScoped<IDesignerRepo, DesignerRepo>();
            services.AddScoped<IMaterialRepo, MaterialRepo>();
            //Add MVC
            services.AddControllersWithViews();

            // For auto update in "design in the browser" situation
            services.AddRazorPages().AddRazorRuntimeCompilation();

            // For shoppingcart feature
            services.AddHttpContextAccessor();
            services.AddSession();
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
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
