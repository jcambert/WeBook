using AutoMapper;
using MicroS_Common.Handlers;
using MicroS_Common.Mongo;
using System.Threading.Tasks;
using webook.domain.typeDePieces.Dto;
using webook.domain.typeDePieces.Queries;
using WeBook.Services.ChannelManager.Repositories;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri Jul 17 2020 11:35:07 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeBook.Services.ChannelManager.Handlers
{
    /// <summary>
    /// Get TypeDePiece Handler
    /// </summary>
    public partial class GetTypeDePieceHandler :  IQueryHandler<GetTypeDePiece, TypeDePieceDto>
    {
        

        #region Constructors
        public GetTypeDePieceHandler(
            IBrowseTypeDePieceRepository repository,
             IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }
        #endregion

        #region public properties
        public IBrowseTypeDePieceRepository Repository{get;}
        public IMapper Mapper{get;}
        #endregion

        #region public functions
        /// <summary>
        ///  Handle the command with context
        /// </summary>
        /// <param name="command">The command to handle</param>
        /// <param name="context">The correlation context</param>
        /// <returns></returns>
        public async Task<TypeDePieceDto> HandleAsync(GetTypeDePiece query)
        {
            var model = await Repository.GetAsync(query.Id);

            return model == null ? null : Mapper.Map<TypeDePieceDto>(model);

        }
        #endregion
    }
}