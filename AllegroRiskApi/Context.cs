using AllegroRiskApi.Model;
using MongoDB.Driver;

namespace AllegroRiskApi
{
    public class Context
    {
        private readonly IMongoDatabase database;
        public Context() {
            database = new MongoClient("mongodb://admin:1234@cluster0-shard-00-00-lmqdb.azure.mongodb.net:27017,cluster0-shard-00-01-lmqdb.azure.mongodb.net:27017,cluster0-shard-00-02-lmqdb.azure.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true")
                .GetDatabase("AllegroRisk");
        }

        public IMongoCollection<Activo> Activo {
            get {
                return database.GetCollection<Activo>("activo");
            }
        }

    }
}
