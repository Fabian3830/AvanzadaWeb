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
    public class TbCategoria : ent.ICRUD<data.TbCategoria>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbCategoria().Remove(id);
            return "";
        }

        public async Task<string> GetAll()
        {
            var objetos = await new DAL.TbCategoria().Get();
            return JsonConvert.SerializeObject(objetos);
        }

        public async Task<string> GetOneById(string id)
        {
            var objeto = await new DAL.TbCategoria().Get(id) ?? new data.TbCategoria();
            return JsonConvert.SerializeObject(objeto);
        }

        public async Task<string> Insert(data.TbCategoria entity)
        {
            await new DAL.TbCategoria().Create(entity);
            return "";
        }

        public async Task<string> Updated(string id, data.TbCategoria entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbCategoria().Update(id, entity);
        }


    }
}
