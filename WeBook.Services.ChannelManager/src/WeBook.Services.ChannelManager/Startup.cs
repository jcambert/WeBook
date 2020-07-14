using MicroS_Common.Services.Service;
using Microsoft.Extensions.Configuration;
using System;
using WeBook.Domain;

namespace WeBook.Services.ChannelManager
{
    public class Startup : ServiceStartup
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        protected override Type DomainType => typeof(DomainProfile);
    }
}
