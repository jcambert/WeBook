using AutoMapper;
using MicroS_Common.Handlers;
using MicroS_Common.RabbitMq;
using MicroS_Common.Types;
using MicroS_Common.Mongo;
using System;
using System.Threading.Tasks;
using webook.domain.typeDePieces.Domain;
using webook.domain.typeDePieces.Messages.Commands;
using webook.domain.typeDePieces.Messages.Events;
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
    /// Delete TypeDePiece Handler
    /// </summary>
    public partial class CreateTypeDePieceHandler : DomainCommandHandler<CreateTypeDePiece,TypeDePiece,string>
    {
        

        #region Constructors
        public CreateTypeDePieceHandler(
            IBrowseTypeDePieceRepository repository,
            IBusPublisher busPublisher,
            IMapper mapper):base(busPublisher,mapper,repository){}
        #endregion

        #region Protected Overrides functions
        /// <summary>
        /// Check if the model exist by Command
        /// </summary>
        /// <param name="command">The command in wich information can be use do check if the model exist in database</param>
        /// <returns>Nothing</returns>
        protected override async Task<bool> CheckExist(string id)
        {
            if (await base.CheckExist(id))
            {
                throw new MicroSException("typeDePiece_already_exists",$"TypeDePiece: '{id}' already exists.");
            }
           return true;
        }
        #endregion

        #region Public Overrides functions
        /// <summary>
        ///  Handle the command with context
        /// </summary>
        /// <param name="command">The command to handle</param>
        /// <param name="context">The correlation context</param>
        /// <returns></returns>
        public override async Task HandleAsync(CreateTypeDePiece command, ICorrelationContext context)
        {

            await base.HandleAsync(command, context);

            var product = GetDomainObject(command);
            product.CreatedDate = product.UpdatedDate = DateTime.Now;
            
            await Repository.AddAsync(product);

            await BusPublisher.PublishAsync(CreateEvent<TypeDePieceCreated>(command), context);
        }
        #endregion
    }
}