using MicroS_Common.Mongo;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using webook.domain.typeDeProprietes.Domain;
using WeCommon;

namespace WeBook.Services.ChannelManager
{
#if DEBUG
    public class ChannelSeeder : MongoDbSeeder
    {
        public ChannelSeeder(IMongoDatabase database) : base(database)
        {
        }

        protected override async Task CustomSeedAsync()
        {
            await base.CustomSeedAsync();
            await Database.DropCollectionAsync(TypeDePropriete.COLLECTION_NAME);
            var col = Database.GetCollection<TypeDePropriete>(TypeDePropriete.COLLECTION_NAME);
            List<TypeDePropriete> tpList = new List<TypeDePropriete>() { 
                 new TypeDePropriete(){Nom=new Property<string>(){["fr"]="toto",["es"]="titi" } },
            };
            await col.InsertManyAsync(tpList);
        }

        private TypeDePropriete CreateTypeDePropriete(params string[] desc)
        {
            TypeDePropriete tp = new TypeDePropriete();
            return tp;
        }
    }
#endif
}
