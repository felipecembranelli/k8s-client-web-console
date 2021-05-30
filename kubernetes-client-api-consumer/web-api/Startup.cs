using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using KubeInspector.Repositories;
using Microsoft.AspNetCore.Routing;

namespace KubeInspector
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IKubernetesRepository, KubernetesRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // app.Use(next => context =>
            // {
            //     var endpoint = context.GetEndpoint();
            //     if (endpoint is null)
            //     {
            //         return Task.CompletedTask;
            //     }
                
            //     Console.WriteLine($"Endpoint: {endpoint.DisplayName}");

            //     if (endpoint is RouteEndpoint routeEndpoint)
            //     {
            //         Console.WriteLine("Endpoint has route pattern: " +
            //             routeEndpoint.RoutePattern.RawText);
            //     }

            //     foreach (var metadata in endpoint.Metadata)
            //     {
            //         Console.WriteLine($"Endpoint has metadata: {metadata}");
            //     }

            //     return Task.CompletedTask;
            // });

            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapGet("/", async context =>
            //     {
            //         await context.Response.WriteAsync("Hello World! 2");
            //     });
            // });
        }
    }
}
