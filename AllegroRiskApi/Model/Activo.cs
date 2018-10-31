using MongoDB.Bson.Serialization.Attributes;

namespace AllegroRiskApi.Model
{
    public class Activo { 
    
       [BsonId]
       [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string importancia { get; set; }

        public string asignado { get; set; }

        public string requisitosSeguridad { get; set; }

        public string requisitoImportante { get; set; }

        

    }
}
