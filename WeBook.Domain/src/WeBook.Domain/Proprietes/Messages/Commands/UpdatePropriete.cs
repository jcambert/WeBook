using System;
using MicroS_Common.Domain;
using webook.domain.proprietes.Messages.Events;


using WeCommon;
using MongoDB.Bson.Serialization.Attributes;
using webook.domain.proprietes.Domain;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 17:12:03 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.proprietes.Messages.Commands
{
    [OnRejected(typeof(UpdateProprieteRejected))]
    public class UpdatePropriete : CreatePropriete
    {
        
        public UpdatePropriete(Guid id,string nom,string telephone,string fax,string email,string siteweb,string nomducontact,string prenomducontact,string devise,string symbolededeviseavantleprix,string symbolededeviseapresleprix,string typedelocation,string identifiantautorite,int ordreaffichage,Property<string> politiquegenerale,Property<string> politiqueannulation,Adresse adresse) 
            : base(id,nom,telephone,fax,email,siteweb,nomducontact,prenomducontact,devise,symbolededeviseavantleprix,symbolededeviseapresleprix,typedelocation,identifiantautorite,ordreaffichage,politiquegenerale,politiqueannulation,adresse)
        {
        }
    }
}