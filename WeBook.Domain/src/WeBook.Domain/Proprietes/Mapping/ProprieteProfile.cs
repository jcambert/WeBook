using AutoMapper;
using webook.domain.proprietes.Domain;
using webook.domain.proprietes.Dto;

using webook.domain.proprietes.Messages.Commands;
using webook.domain.proprietes.Messages.Events;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 17:12:03 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.proprietes.Mapping
{
    public class ProprieteProfile:Profile
    {
        public ProprieteProfile()
        {
            CreateMap<Propriete, ProprieteDto>();
            
            CreateMap<CreatePropriete, Propriete>();
            CreateMap<CreatePropriete, ProprieteCreated>();
            CreateMap<UpdatePropriete, ProprieteUpdated>();
            CreateMap<DeletePropriete, ProprieteDeleted>();
            
        }
    }
}
