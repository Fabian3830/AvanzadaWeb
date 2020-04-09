using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DO.Objetos
{
    public class TbHistorial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
#nullable enable
        public string? _id { get; set; }
#nullable disable

        public DateTime dFecha { get; set; }

        public bool bMinTest { get; set; }

        public int iDuracion { get; set; }

        public string sCliente { get; set; }

        public string sReceta { get; set; }

    }
}
