using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using static System.Net.WebRequestMethods;
using cw3.Services;
using Cw3.Middlewares;
using Cw3.ModelsF;
using Microsoft.EntityFrameworkCore;

namespace Cw3
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
            services.AddDbContext<s18625Context>(opt =>
            {
                opt.UseSqlServer("Data Source=db-mssql;Initial Catalog=s18625;Integrated Security=True");
            });
            services.AddTransient<IDbService, SqlServerDbService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbService dbService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage( );
            }


            //app.UseMiddleware<LoggingMiddleware>();

            //app.Use(async (context, next) =>
            //{

            //    if (!context.Request.Headers.ContainsKey("Index"))
            //    {
            //        context.Response.StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status401Unauthorized;
            //        await context.Response.WriteAsync("Nie podales loginu "+ context.Request.Headers.Keys);
            //        return;
            //    }
            //    else
            //    {
            //        string index = context.Request.Headers["Index"].ToString();
            //        await context.Response.WriteAsync("Podales login");
            //    }

            //    await next();
            //});


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
