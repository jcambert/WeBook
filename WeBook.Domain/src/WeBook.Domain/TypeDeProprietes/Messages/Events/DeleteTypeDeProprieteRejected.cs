using System;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 16:56:25 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.typeDeProprietes.Messages.Events
{
    public class DeleteTypeDeProprieteRejected : TypeDeProprieteBaseRejectedEvent
    {
        public DeleteTypeDeProprieteRejected(Guid id, string reason, string code) : base(id, reason, code)
        {
        }
    }
}