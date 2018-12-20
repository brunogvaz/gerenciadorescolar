using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorEscolar.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GerenciadorEscolar
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IAlunoData, InMemoryAlunoData>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                                IHostingEnvironment env,
                                IGreeter greeter,
                                ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(ConfgureRoutes);

            //app.UseFileServer();

            app.Run(async (context) =>
            {


               // throw new Exception("Fudeu");
                var greeting = greeter.GetMessageofDay();
                logger.LogInformation("Information");

                // await context.Response.WriteAsync($" {greeting} : {env.EnvironmentName}");
                await context.Response.WriteAsync($" Not Found");
            });
        }

        private void ConfgureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default",
            "{controller=Home}/{action=index}/{id?}");
        }
    }
}
