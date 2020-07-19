using MicroS_Common.Mongo;
using MicroS_Common.Types;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webook.domain;
using webook.domain.typeDePieces.Domain;
using webook.domain.typeDeProprietes.Domain;
using WeCommon;

namespace WeBook.Services.ChannelManager
{
    public partial class ChannelSeeder : MongoDbSeeder
    {
        Dictionary<string, List<string>> typeprops = new Dictionary<string, List<string>>()
        {
            { "fr",  new List<string>(){"Appartement", "Chambre d'hôtes", "Cabane", "Maison d'hôtes", "Auberge", "Hôtel", "Maison", "Villa", "Appart'hôtel", "Grange", "Bateau", "Hôtel de charme","Immeuble","Bungalow","Camping","Caravane","Casa Particular","Château","Chacara","Chalet","Château","Condo","Cottage","Maison cycladique","Estate","Farmhouse","Heritage Hotel","House Boat","Lodge","Loft","Mas","Mill","Mobile Home","Recreational Vehicle","Resort","Riad","Résidence","Studio","Tente","Tour","Tour","Maison de ville","Maison dans les arbres","Yacht"} },
            { "en",  new List<string>(){"Apartment","Bed and Breakfast","Cabin","Guesthouse","Hostel","Hotel","House","Villa","Aparthotel","Barn","Boat","Boutique Hotel","Building","Bungalow","Camping","Caravan","Casa Particular","Castle","Chacara","Chalet","Chateau","Condo","Cottage","Cycladic House","Estate","Farmhouse","Heritage Hotel","House Boat","Lodge","Loft","Mas","Mill","Mobile Home","Recreational Vehicle","Resort","Riad","Serviced Apartment","Studio","Tent","Tour","Tower","Townhome","Tree House","Yacht"} }
        };
        Dictionary<string, List<string>> typerooms = new Dictionary<string, List<string>>()
        {
            { "fr",  new List<string>(){"Principal", "Chambre", "Salle de bains"} },
            { "en",  new List<string>(){"Main","Bedroom", "Bathrooms" } }
        };

        public ChannelSeeder(IMongoDatabase database, ILogger<MongoDbSeeder> logger) : base(database, logger)
        {
        }

       

        private List<TModel> CreateDatas<TModel>(Dictionary<string, List<string>> dico)
            where TModel:Entity<string>,INom,new()
        {
            var datas = new List<TModel>();
            var langs = dico.Keys.Where(p => p != "fr");
            foreach (var tp in dico["fr"].Select((value, index) => new { Value = value, Index = index }))
            {
                var p = new Property<string>();
                foreach (var lang in langs)
                {
                    p[lang] = dico[lang][tp.Index];
                }
                if (!datas.Where(d => d.Id.Equals(  dico["fr"][tp.Index])).Any())
                    datas.Add(new TModel() { Id = dico["fr"][tp.Index], Nom = p });
                else
                {
                    Logger.LogError($"{dico["fr"][tp.Index]} key already defined !!");
                    //   Debugger.Break();
                }
            }
            return datas;
        }

        private async Task DropAndInsert<TModel>(List<TModel> datas,string collection)
            where TModel : Entity<string>, INom, new()
        {
            await Database.DropCollectionAsync(collection);
            var col = Database.GetCollection<TModel>(collection);
            await col.InsertManyAsync(datas);
        }

        protected override void FeedSeeder()
        {
            Seeders.Add(AddTypeDePropriete());
            Seeders.Add(AddTypeDePiece());

        }
        private Action AddTypeDePropriete()=>
         async () =>
            {
                await DropAndInsert<TypeDePropriete>(CreateDatas<TypeDePropriete>(typeprops), TypeDePropriete.COLLECTION_NAME);
            };
        private Action AddTypeDePiece() =>
         async () =>
         {
             await DropAndInsert<TypeDePiece>(CreateDatas<TypeDePiece>(typerooms), TypeDePiece.COLLECTION_NAME);
         };
    }
}
