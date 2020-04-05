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
    public class TbCliente : ent.ICRUD<data.TbCliente>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbCliente().Remove(id);
            return "";
        }

        public async Task<string> GetAll()
        {
            var objetos = await new DAL.TbCliente().Get();
            return JsonConvert.SerializeObject(objetos);
        }

        public async Task<string> GetOneById(string id)
        {
            var objeto = await new DAL.TbCliente().Get(id) ?? new data.TbCliente();
            return JsonConvert.SerializeObject(objeto);
        }

        public async Task<string> Insert(data.TbCliente entity)
        {
            await new DAL.TbCliente().Create(entity);
            return "";
        }

        public async Task<string> Updated(string id, data.TbCliente entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbCliente().Update(id, entity);
        }


    }
}
