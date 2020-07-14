using System;
using MicroS_Common.Mongo;


using WeCommon;
using MongoDB.Bson.Serialization.Attributes;
using MicroS_Common.Types;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun Jul 12 2020 16:56:24 GMT+0200 (GMT+02:00)
/// </summary>
namespace webook.domain.typeDeProprietes.Domain
{
    [MongoDocument(TypeDePropriete.COLLECTION_NAME)]
    public partial class TypeDePropriete : BaseEntity
    {
        public const string COLLECTION_NAME = "typeDePropriete";
        #region private variables


        #endregion


        #region public properties


        [BsonSerializer(typeof(DynamicSerializer<dynamic, string>))]
        public dynamic Nom { get; set; } = new Property<string>();

        #endregion

        #region Constructeur
        public TypeDePropriete() : base() { }

        public TypeDePropriete(Property<string> nom)
            : base()
        {
            Nom = nom;
        }

        #endregion
        #region public functions
        #endregion

    }
}