using System;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri Jul 17 2020 11:35:07 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.typeDePieces.Messages.Events
{
    public class UpdateTypeDePieceRejected : TypeDePieceBaseRejectedEvent
    {
        public UpdateTypeDePieceRejected(Guid id, string reason, string code) : base(id, reason, code)
        {
        }
    }
}