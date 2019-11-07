using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnnuairePorject.Services;
using AnnuairePorject.Services.Authentication.Interfaces;
using AnnuairePorject.Services.Users;
using AnnuairePorject.Services.Users.Interface;
using AnnuaireProject.DAL.Users;
using AnnuaireProjexct.BLL.Users.Business;
using AnnuaireProjexct.BLL.Users.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AnnuaireProject
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
            services.AddSingleton<ILoginService, LoginService>();
            services.AddSingleton<IUserBusiness, UserBusiness>();
            services.AddSingleton<IUserRepository, InMemoryUserRepository>();
            services.AddSingleton<IUserService, UserService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
