using System;
using System.Collections.Generic;

using WeCommon;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 17:12:03 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.proprietes.Messages.Events
{
    public class ProprieteCreated : ProprieteBaseEvent
    {
        public Guid Id { get; }

        public string  Nom{get;}
        public string  Telephone{get;}
        public string  Fax{get;}
        public string  Email{get;}
        public string  SiteWeb{get;}
        public string  NomDuContact{get;}
        public string  PrenomDuContact{get;}
        public string  Devise{get;}
        public string  SymboleDeDeviseAvantLePrix{get;}
        public string  SymboleDeDeviseApresLePrix{get;}
        public string  TypeDeLocation{get;}
        public string  IdentifiantAutorite{get;}
        public int  OrdreAffichage{get;}
        
        public Property<string>  PolitiqueGenerale{get;}
        public Property<string>  PolitiqueAnnulation{get;}
        
        
        #region Constructor
        public ProprieteCreated(Guid id,
        string nom,string telephone,string fax,string email,string siteweb,string nomducontact,string prenomducontact,string devise,string symbolededeviseavantleprix,string symbolededeviseapresleprix,string typedelocation,string identifiantautorite,int ordreaffichage,Property<string> politiquegenerale,Property<string> politiqueannulation
        )
        {
            Id = id;
            Nom = nom ;
            Telephone = telephone ;
            Fax = fax ;
            Email = email ;
            SiteWeb = siteweb ;
            NomDuContact = nomducontact ;
            PrenomDuContact = prenomducontact ;
            Devise = devise ;
            SymboleDeDeviseAvantLePrix = symbolededeviseavantleprix ;
            SymboleDeDeviseApresLePrix = symbolededeviseapresleprix ;
            TypeDeLocation = typedelocation ;
            IdentifiantAutorite = identifiantautorite ;
            OrdreAffichage = ordreaffichage ;
            PolitiqueGenerale = politiquegenerale ;
            PolitiqueAnnulation = politiqueannulation ;
            
            
        }
        #endregion
    }
}