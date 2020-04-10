using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DO.Objetos
{
    public class aCompras  
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
#nullable enable
        public string? _id { get; set; }

        public bool bActivo { get; set; }

        public int iPrecio { get; set; }

        public string sUrlImagen { get; set;}

    }
}
