using MicroS_Common.Services.Identity;
using MicroS_Common.Services.Identity.Dto;
using Microsoft.Extensions.Configuration;
using System;


namespace WeBook.Services.Identity
{
    /// <summary>
    /// Startup Class for Identity Service
    /// @author:AMBERT Jean-Christophe
    /// @date: 09/07/2020
    /// </summary>
    public class Startup: BaseIdentityStartup
    {
        /// <summary>
        /// Entry Point Of Identity Service
        /// </summary>
        /// <param name="configuration">Configuration Container @see appsettings.json</param>
        public Startup(IConfiguration configuration):base(configuration)
        {

        }

        protected override Type DomainType => typeof(User);
    }
}
