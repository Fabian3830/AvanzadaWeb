using System;
using System.Collections.Generic;
using System.Text;
using ent = DO.Interface;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DAL;
using data = DO.Objetos;
using Newtonsoft.Json;

namespace BS
{
    public class TbFactura : ent.ICRUD<data.TbFactura>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbFactura().Remove(id);
            return "";
        }

        public async Task<IEnumerable<DO.Objetos.TbFactura>> GetAll()
        {
            var objetos = await new DAL.TbFactura().Get();
            //return JsonConvert.SerializeObject(objetos);
            return objetos;
        }

        public async Task<DO.Objetos.TbFactura> GetOneById(string id)
        {
            var objeto = await new DAL.TbFactura().Get(id) ?? new data.TbFactura();
            return objeto;
        }

        public async Task<string> Insert(data.TbFactura entity)
        {
            
            /*var acom =JsonConvert.DeserializeObject<data.oDirección>(entity.oDireccion.ToString());
            entity.oDireccion = acom;*/


            data.aCompras[] acompras=new data.aCompras[entity.aCompras.Length];
            
            for (int i = 0; i < entity.aCompras.Length; i++)
            {
             
                  acompras[i] = JsonConvert.DeserializeObject<data.aCompras>(entity.aCompras[i].ToString());

            }
            entity.aCompras = acompras;

            await new DAL.TbFactura().Create(entity);
            return "insertado";
        }

        public async Task<string> Updated(string id, data.TbFactura entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbFactura().Update(id, entity);
        }


    }
}