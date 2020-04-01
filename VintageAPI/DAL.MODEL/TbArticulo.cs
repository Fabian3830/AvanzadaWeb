using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.MODEL
{
    public class TbArticulo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
#nullable enable
        public string? _id { get; set; }
#nullable disable

        public string sNombre { get; set; }

        public int iCant { get; set; }

        public int iPrecio { get; set; }

        public string sDescripcion { get; set; }

        public string sUrlImagen { get; set; }

        public bool bActivo { get; set; }

    }
}
