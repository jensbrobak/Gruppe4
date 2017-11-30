using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using LunchTime.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LunchTime.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AutoMapper;

namespace LunchTime
{
    public class Startup
    {
        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _env;

        public Startup(IConfiguration config, IHostingEnvironment env)
        {
            _config = config;
            _env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<Customer, IdentityRole>(cfg => 
            {
                cfg.User.RequireUniqueEmail = true;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireUppercase = false;
            })
                .AddEntityFrameworkStores<LunchTimeContext>(); // how to connect to db

            services.AddDbContext<LunchTimeContext>(cfg => 
            {
                cfg.UseSqlServer(_config.GetConnectionString("LunchTimeConnectionString"));
            });

            services.AddAutoMapper(); //looks for AutoMapper profiles - a way to setup these mappings

            services.AddTransient<LunchTimeSeeder>();

            services.AddScoped<ILunchTimeRepository, LunchTimeRepository>();

            services.AddMvc(opt => 
            {
                if (_env.IsProduction())
                {
                    opt.Filters.Add(new RequireHttpsAttribute()); // Hole site require Https only in production because we use credentials
                }
            })
            .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore); // Ignores the selfreferenceloop in Order/OrderItem
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //This is no longer nessesary now with the mapRoute
            //app.UseDefaultFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
            
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(cfg =>
            {
                cfg.MapRoute("Default",
                    "{controller}/{action}/{id?}",
                    new { controller = "App", Action = "Index" });
            });

            if (env.IsDevelopment())
            {
                // Seed the database
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var seeder = scope.ServiceProvider.GetService<LunchTimeSeeder>();
                    seeder.Seed().Wait();
                }
            }
        }
    }
}
