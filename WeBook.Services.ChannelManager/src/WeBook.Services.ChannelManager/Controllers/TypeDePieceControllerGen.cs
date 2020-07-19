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
using webook.domain.typeDePieces.Dto;
using webook.domain.typeDePieces.Queries;
#endregion

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri Jul 17 2020 11:35:07 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeBook.Services.ChannelManager.Controllers
{
    [Route("typeDePieces")]
    public partial class TypeDePiecesController : BaseController
    {
        public TypeDePiecesController(IDispatcher dispatcher,IConfiguration config,IOptions<AppOptions> appOptions) : base(dispatcher,config,appOptions)
        {
        }

        [HttpGet("")]
        public async Task<ActionResult<PagedResult<TypeDePieceDto>>> Get([FromQuery] BrowseTypeDePieces query)
            => Collection(await QueryAsync(query));

        [HttpGet("{id}")]
        public async Task<ActionResult<TypeDePieceDto>> Get([FromRoute] GetTypeDePiece query)
            => Single(await QueryAsync(query));
        
        
    }
}