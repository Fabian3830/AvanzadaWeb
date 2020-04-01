using System;
using System.Collections.Generic;
using System.Text;
using ent = DO.Interface;
using data = DAL.MODEL;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DAL;

namespace BS
{
    public class TbArticulo : ent.ICRUD<data.TbArticulo>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbArticulo().Remove(id);
            return "";
        }

        public async Task<string> GetAll()
        {
            var objetos = await new DAL.TbArticulo().Get();
            return JsonConvert.SerializeObject(objetos);
        }

        public async Task<string> GetOneById(string id)
        {
            var objeto = await new DAL.TbArticulo().Get(id) ?? new data.TbArticulo();
            return JsonConvert.SerializeObject(objeto);
        }

        public async Task<string> Insert(data.TbArticulo entity)
        {
            await new DAL.TbArticulo().Create(entity);
            return "";
        }

        public async Task<string> Updated(string id, data.TbArticulo entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbArticulo().Update(id, entity);
        }


    }
}
