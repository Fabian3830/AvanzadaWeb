using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DO.Objetos
{
    public class TbFactura
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
#nullable enable
        public string? _id { get; set; }
#nullable disable
        public string sCliente { get; set; }

        public BsonDateTime dFecha { get; set; }
#nullable enable
        public IEnumerable<object>? aCompras { get; set; }
#nullable disable
        public int iSubtotal { get; set; }

        public int iTotal { get; set; }
#nullable enable
        public object? oDireccion { get; set; }
#nullable disable

    }
}
