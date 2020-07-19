using System;
using MicroS_Common.Domain;
using webook.domain.typeDePieces.Messages.Events;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri Jul 17 2020 11:35:07 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.typeDePieces.Messages.Commands
{
    [OnRejected(typeof(DeleteTypeDePieceRejected))]
    public class DeleteTypeDePiece: TypeDePieceBaseCommand
    {
        
        public override string Id { get; set; }
        public DeleteTypeDePiece(string id) : base()
        {
            this.Id = id;
        }
        

    }
}