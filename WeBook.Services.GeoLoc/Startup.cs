using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WeBook.Services.GeoLoc
{
    public class Startup
    {
        private const string API_KEY= "AIzaSyCBhkBpgLNwPCMoKCknEP1UwLnCVBkMpgU";
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
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
                
                endpoints.MapGet("/", async context =>
                {
                    HttpClient clt = new HttpClient();
                    var lat = 47.5021719;
                    var lon = 6.9811143;
                    var url = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={lat},{lon}&key={API_KEY}";
                    var response=await clt.GetAsync(url);
                    await context.Response.WriteAsync(await response.Content.ReadAsStringAsync() );
                });
            });
        }
    }
}
