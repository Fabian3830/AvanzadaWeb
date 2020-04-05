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
    public class TbReceta : ent.ICRUD<data.TbReceta>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbReceta().Remove(id);
            return "";
        }

        public async Task<string> GetAll()
        {
            var objetos = await new DAL.TbReceta().Get();
            return JsonConvert.SerializeObject(objetos);
        }

        public async Task<string> GetOneById(string id)
        {
            var objeto = await new DAL.TbReceta().Get(id) ?? new data.TbReceta();
            return JsonConvert.SerializeObject(objeto);
        }

        public async Task<string> Insert(data.TbReceta entity)
        {
            await new DAL.TbReceta().Create(entity);
            return "";
        }

        public async Task<string> Updated(string id, data.TbReceta entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbReceta().Update(id, entity);
        }


    }
}