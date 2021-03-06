﻿using System;
using System.Collections.Generic;
using System.Text;
using ent = DO.Interface;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DAL;
using data = DO.Objetos;

namespace BS
{
    public class TbArticulo : ent.ICRUD<data.TbArticulo>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbArticulo().Remove(id);
            return "ok";
        }

        public async Task<IEnumerable<DO.Objetos.TbArticulo>> GetAll()
        {
            var objetos = await new DAL.TbArticulo().Get();
            //return JsonConvert.SerializeObject(objetos);
            return objetos;
        }

        public async Task<DO.Objetos.TbArticulo> GetOneById(string id)
        {
            var objeto = await new DAL.TbArticulo().Get(id) ?? new data.TbArticulo();
            return objeto;
        }

        public async Task<string> Insert(data.TbArticulo entity)
        {
            await new DAL.TbArticulo().Create(entity);
            return "insertado";
        }

        public async Task<string> Updated(string id, data.TbArticulo entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbArticulo().Update(id, entity);
        }

        public async Task<IEnumerable<DO.Objetos.TbArticulo>> customQuery(string query)
        { var objetos = await new DAL.TbArticulo().customQuery(query); return objetos; }
    }
}
