using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Repositories;
using B.HardwareTown.Infrastructure.Repositories;
using B.HardwareTown.Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using B.HardwareTown.Infrastructure;
using Microsoft.EntityFrameworkCore.InMemory;
using B.HardwareTown.ApplicationCore.Models;

namespace B.HardwareTown.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseInMemoryDatabase("TestDB"));

			services.AddIdentity<Customer, IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();

			services.AddLogging();
			services.AddScoped<ICategoryRepository, InMemoryCategoryRepository>();
            services.AddScoped<IProductRepository, InMemoryProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddLogging();
			services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            
            //logging base info. to console
            loggerFactory.AddDebug();
            loggerFactory.AddConsole();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
                app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}
            app.UseStatusCodePagesWithReExecute("/StatusCode/{0}");
            app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseAuthentication();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
    }
}
