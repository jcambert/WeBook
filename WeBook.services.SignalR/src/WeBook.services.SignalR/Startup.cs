
using MicroS_Common.Services.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WeStrap;

namespace WeBook.services.SignalR
{
    public class Startup : ServiceStartup
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        protected override Type DomainType => typeof(object);

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
            services.AddWeStrap();
        }
    }
}
