using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KittenKatKookie.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace KittenKatKookie
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie();

            services.AddMvc()
                .AddRazorPagesOptions(options=>
                {
                    options.Conventions.AuthorizeFolder("/CRUD");
                    options.Conventions.AuthorizeFolder("/Account");
                    //otherwise, login will not be accessible
                    options.Conventions.AllowAnonymousToPage("/Account/Login");
                });

            //AddTransient create new instance of the class everytime one is requested
            //AssSingleton create 1 instance for the lifetime of the application and only return it once it is requested
            //AddScoped create 1 instance of the class for each web request, reuse that instance for the whole request
            //and clean that instance once the web request is finished
            services.AddScoped<IRecipesService, RecipesService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
