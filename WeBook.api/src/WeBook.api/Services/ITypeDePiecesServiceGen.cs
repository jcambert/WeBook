using MicroS_Common.Types;
using MicroS_Common.RestEase;
using RestEase;
using System;
using System.Threading.Tasks;
using webook.domain.typeDePieces.Dto;
using webook.domain.typeDePieces.Queries;
using static webook.api.Services.ServiceForwarder;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri Jul 17 2020 11:35:07 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.api.Services
{
    /// <summary>
    /// TypeDePiece Service created by <see cref="https://www.nuget.org/packages/RestEase/">Restease</see>
    /// </summary>
    [ServiceForwarder(CHANNEL_MANAGER_SERVICE)]
    [SerializationMethods(Query = QuerySerializationMethod.Serialized)]
    public partial interface ITypeDePiecesService
    {
        /// <summary>
        /// Get typeDePiece by its Id
        /// </summary>
        /// <param name="id">the id of  TypeDePiece</param>
        /// <returns>TypeDePieceDto</returns>
        [AllowAnyStatusCode]
        [Get("typeDePieces/{id}")]
        Task<TypeDePieceDto> GetAsync([Path] Guid id);


         /// <summary>
        /// Get list of typeDePieces by BrowseTypeDePieces Query
        /// </summary>
        /// <param name="query">The Browse typeDePieces query</param>
        /// <returns>a list of TypeDePieceDto</returns>
        [AllowAnyStatusCode]
        [Get("typeDePieces")]
        Task<PagedResult<TypeDePieceDto>> BrowseAsync([Query] BrowseTypeDePieces query);
    }
}
