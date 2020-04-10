using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DO.Objetos
{
    public class TbReceta :aCompras
    {
        
#nullable disable

        public string sNombre { get; set; }
#nullable enable
        public IEnumerable<string>? aEtiqueta { get; set; }
#nullable disable
        public DateTime dFechaPublicacion { get; set; }

        public string sTexto { get; set; }
 

        public string sUrlVideo { get; set; }

        

        public string sUrlVideoTrailer { get; set; }

       

    }
}
