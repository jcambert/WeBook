using System;
using MicroS_Common.Domain;
using webook.domain.typeDeProprietes.Messages.Events;


using WeCommon;
using MongoDB.Bson.Serialization.Attributes;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 16:56:24 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.typeDeProprietes.Messages.Commands
{

    [OnRejected(typeof(CreateTypeDeProprieteRejected))]
    public class CreateTypeDePropriete : TypeDeProprieteBaseCommand
    {
        
        public override Guid Id { get; set; }
        
        
        
        public Property<string> Nom {get;}


        public CreateTypeDePropriete(
            Guid id,Property<string> nom) : base()
        {
            
            Id = id;
            
            Nom =nom; 

           
        }
    }
}