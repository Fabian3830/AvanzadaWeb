using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DO.Objetos
{
    public class TbCliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
#nullable enable
        public string? _id { get; set; }
#nullable disable
        public string sNombre { get; set; }

        public string sApellido { get; set; }

        public string sContrasena { get; set; }

        public string sCorreo { get; set; }

        public BsonDateTime dNacimiento { get; set; }
#nullable enable
        public IEnumerable<string>? aRecetas { get; set; }

        public IEnumerable<string>? aFavoritos { get; set; }

        public object? oDireccion { get; set; }
#nullable disable
        public bool bActivo { get; set; }

        public bool bAdmin { get; set; }
#nullable enable
        public IEnumerable<string>? aPermisos { get; set; }
#nullable disable
    }
}
