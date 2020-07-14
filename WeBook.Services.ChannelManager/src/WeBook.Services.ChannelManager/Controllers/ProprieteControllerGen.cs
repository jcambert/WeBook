#region using
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MicroS_Common;
using MicroS_Common.Types;
using MicroS_Common.Controllers;
using MicroS_Common.Dispatchers;
using webook.domain.proprietes.Dto;
using webook.domain.proprietes.Queries;
#endregion

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 17:12:03 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeBook.Services.ChannelManager.Controllers
{
    [Route("proprietes")]
    public partial class ProprietesController : BaseController
    {
        public ProprietesController(IDispatcher dispatcher,IConfiguration config,IOptions<AppOptions> appOptions) : base(dispatcher,config,appOptions)
        {
        }

        [HttpGet("")]
        public async Task<ActionResult<PagedResult<ProprieteDto>>> Get([FromQuery] BrowseProprietes query)
            => Collection(await QueryAsync(query));

        [HttpGet("{id}")]
        public async Task<ActionResult<ProprieteDto>> Get([FromRoute] GetPropriete query)
            => Single(await QueryAsync(query));
        
        
    }
}