using AutoMapper;
using Microsoft.Extensions.Logging;
using MicroS_Common.Handlers;
using webook.domain.typeDeProprietes.Domain;
using webook.domain.typeDeProprietes.Dto;
using webook.domain.typeDeProprietes.Queries;
using WeBook.Services.ChannelManager.Repositories;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 16:56:25 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeBook.Services.ChannelManager.Handlers
{
    /// <summary>
    /// Browse TypeDePropriete Handler
    /// </summary>
    public partial class BrowseTypeDeProprieteHandler : BaseBrowseHandler<TypeDePropriete, BrowseTypeDeProprietes, TypeDeProprieteDto, IBrowseTypeDeProprieteRepository>
    {
        public BrowseTypeDeProprieteHandler(IBrowseTypeDeProprieteRepository repository, IMapper mapper,ILogger<BrowseTypeDeProprieteHandler> logger): base(repository, mapper,logger){}
    }
}