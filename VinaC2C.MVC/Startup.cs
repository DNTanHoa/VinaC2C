using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VinaC2C.Data.Context;
using VinaC2C.MVC.ServerHub;
using VinaC2C.Ultilities.AppInfor;

namespace VinaC2C.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<VinaC2CContext>();
            services.AddControllersWithViews();
            services.AddSignalR();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => 
            {
                options.LoginPath = AppGlobal.LoginPath;
                options.ExpireTimeSpan = TimeSpan.FromDays(30);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<SignalServer>("signalServer");
                endpoints.MapHub<ChatServer>("chatServer");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
               
            });
        }
    }
}
