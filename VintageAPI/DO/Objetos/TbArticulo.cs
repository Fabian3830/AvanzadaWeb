using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DO.Objetos
{
    public class TbArticulo  :aCompras
    {
        
        #nullable disable
        public string sNombre { get; set; }

        public int iCant { get; set; }

       

        public string sDescripcion { get; set; }

  

        

    }
}
