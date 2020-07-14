
using MicroS_Common;
using MicroS_Common.Controllers;
using MicroS_Common.Dispatchers;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace WeBook.Services.Identity.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    [Route("")]
    public class HomeController: BaseController
    {
        public HomeController(IDispatcher dispatcher,
            IConfiguration configuration,
            IOptions<AppOptions> appOptions):base(dispatcher, configuration, appOptions)
        {

        }
    }
}
