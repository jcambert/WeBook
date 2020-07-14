using AutoMapper;
using Microsoft.Extensions.Logging;
using MicroS_Common.Handlers;
using webook.domain.proprietes.Domain;
using webook.domain.proprietes.Dto;
using webook.domain.proprietes.Queries;
using WeBook.Services.ChannelManager.Repositories;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 17:12:03 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeBook.Services.ChannelManager.Handlers
{
    /// <summary>
    /// Browse Propriete Handler
    /// </summary>
    public partial class BrowseProprieteHandler : BaseBrowseHandler<Propriete, BrowseProprietes, ProprieteDto, IBrowseProprieteRepository>
    {
        public BrowseProprieteHandler(IBrowseProprieteRepository repository, IMapper mapper,ILogger<BrowseProprieteHandler> logger): base(repository, mapper,logger){}
    }
}
