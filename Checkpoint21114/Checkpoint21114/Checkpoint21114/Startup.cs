using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckPoint21114.Core.Services;
using CheckPoint21114.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Checkpoint21114
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

            services.AddScoped<AppDbContext>();
            services.AddDbContext<AppDbContext>();
            services.AddControllers();

            services.AddScoped<IChoreRepository, ChoreRepository>();
            services.AddScoped<IChoreService, ChoreService>();

            services.AddScoped<IChoreTypeRepository, ChoreTypeRepository>();
            services.AddScoped<IChoreTypeService, ChoreTypeService>();

          


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
