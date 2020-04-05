using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DO.Objetos
{
    public class TbCategoria
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
#nullable enable
        public string? _id { get; set; }
#nullable disable

        public string sNombre { get; set; }

    }
}
