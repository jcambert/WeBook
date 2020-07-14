using MicroS_Common;
using MicroS_Common.Controllers;
using MicroS_Common.Dispatchers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using webook.domain;

namespace WeBook.Services.ChannelManager.Controllers
{
    [Route("")]
    public class HomeController : BaseController
    {
        public HomeController(IDispatcher dispatcher, IConfiguration configuration, IOptions<AppOptions> appOptions) : base(dispatcher, configuration, appOptions)
        {
        }
        [HttpGet("etats")]
        public async Task<ActionResult<List<Etat>>> Get()
            =>Etat.Etats;
    }
}
