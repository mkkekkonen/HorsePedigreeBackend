using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

using AutoMapper;

using horsesBackend.Db;
using horsesBackend.MapperProfiles;

namespace horsesBackend
{
    public class Startup
    {
        readonly string CorsOrigins = "_horseCors";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy(
                name: CorsOrigins,
                builder => builder.WithOrigins("http://localhost:4200")
            ));

            services.AddAutoMapper(typeof(HorseProfile));

            services.AddControllers();

            services.AddDbContext<HorseDbContext>(options =>
                options.UseMySql(
                    "server=localhost;user=pedigree;password=Nh34x0W4MqvG;database=horse_pedigree",
                    new MySqlServerVersion(new Version(5, 0, 2))
                ).EnableDetailedErrors()
            );
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

            app.UseCors(CorsOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
