using MicroS_Common.Services.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WeBook.Domain;

namespace WeBook.api
{
    public class Startup: ServiceStartup
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        protected override bool UseCors => true;
        protected override Type DomainType => typeof(DomainProfile);
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
            services.AddAuthorization(x => x.AddPolicy("admin", p => p.RequireRole("admin")));
        }
    }
}
