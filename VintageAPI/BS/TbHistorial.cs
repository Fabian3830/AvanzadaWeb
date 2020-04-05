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
    public class TbHistorial : ent.ICRUD<data.TbHistorial>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbHistorial().Remove(id);
            return "";
        }

        public async Task<string> GetAll()
        {
            var objetos = await new DAL.TbHistorial().Get();
            return JsonConvert.SerializeObject(objetos);
        }

        public async Task<string> GetOneById(string id)
        {
            var objeto = await new DAL.TbHistorial().Get(id) ?? new data.TbHistorial();
            return JsonConvert.SerializeObject(objeto);
        }

        public async Task<string> Insert(data.TbHistorial entity)
        {
            await new DAL.TbHistorial().Create(entity);
            return "";
        }

        public async Task<string> Updated(string id, data.TbHistorial entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbHistorial().Update(id, entity);
        }


    }
}
