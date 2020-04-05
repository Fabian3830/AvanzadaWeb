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
    public class TbFactura : ent.ICRUD<data.TbFactura>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbFactura().Remove(id);
            return "";
        }

        public async Task<string> GetAll()
        {
            var objetos = await new DAL.TbFactura().Get();
            return JsonConvert.SerializeObject(objetos);
        }

        public async Task<string> GetOneById(string id)
        {
            var objeto = await new DAL.TbFactura().Get(id) ?? new data.TbFactura();
            return JsonConvert.SerializeObject(objeto);
        }

        public async Task<string> Insert(data.TbFactura entity)
        {
            await new DAL.TbFactura().Create(entity);
            return "";
        }

        public async Task<string> Updated(string id, data.TbFactura entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbFactura().Update(id, entity);
        }


    }
}