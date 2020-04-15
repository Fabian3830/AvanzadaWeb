using System;
using System.Collections.Generic;
using System.Text;
using ent = DO.Interface;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DAL;
using data = DO.Objetos;

namespace BS
{
    public class TbReceta : DO.Interface.ICRUD<data.TbReceta>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbReceta().Remove(id);
            return "";
        }

        public async Task<IEnumerable<DO.Objetos.TbReceta>> GetAll()
        {
            IEnumerable<DO.Objetos.TbReceta>  objetos = await new DAL.TbReceta().Get();
            //return JsonConvert.SerializeObject(objetos);
            return objetos;
        }

        public async Task<DO.Objetos.TbReceta> GetOneById(string id)
        {
            var objeto = await new DAL.TbReceta().Get(id) ?? new data.TbReceta();
            return  objeto;
        }

        public async Task<string> Insert(data.TbReceta entity)
        {
            await new DAL.TbReceta().Create(entity);
            return "insertado";
        }

        public async Task<string> Updated(string id, data.TbReceta entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbReceta().Update(id, entity);
        }

        public async Task<IEnumerable<DO.Objetos.TbReceta>> customQuery(string query)
        { var objetos = await new DAL.TbReceta().customQuery(query); return objetos; }
    }
}
