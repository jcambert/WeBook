using Newtonsoft.Json;
using System;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 17:12:03 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.proprietes.Messages.Events
{
    public class ProprieteDeleted:ProprieteBaseEvent
    {

        public override Guid Id { get; }

        public ProprieteDeleted(Guid id)
        {
            Id = id;
        }
    }
}
