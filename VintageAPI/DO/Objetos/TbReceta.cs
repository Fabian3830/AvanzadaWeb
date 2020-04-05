using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DO.Objetos
{
    public class TbReceta
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
#nullable enable
        public string? _id { get; set; }
#nullable disable

        public string sNombre { get; set; }
#nullable enable
        public IEnumerable<string>? aEtiqueta { get; set; }
#nullable disable
        public string dFechaPublicacion { get; set; }

        public string sTexto { get; set; }

        public int iPrecio { get; set; }

        public string sUrlVideo { get; set; }

        public string sUrlImagen { get; set; }

        public bool bActivo { get; set; }

    }
}
