﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BS;
using data = DO.Objetos;

namespace VintageAPI.Controllers
{

    [Route("Receta")]
    [ApiController]
    [Produces("application/json")]
    public class TbRecetaController : ControllerBase
    {
        

        [HttpGet("e")]
        public string GetVerga()
        {
            //var xyz = context.HttpContext.Request?.Headers["Basic"];
            
            return "asd";
        }

        [HttpGet]   
        public Task<IEnumerable<DO.Objetos.TbReceta>> Get()
        {
            return new BS.TbReceta().GetAll();
        }

        [HttpGet("{id}")]
        public Task<DO.Objetos.TbReceta> Get(string id)
        {
            return new BS.TbReceta().GetOneById(id);
        }

        [HttpPost]
        public Task<string> Post([FromBody] data.TbReceta receta)
        {
            return new BS.TbReceta().Insert(receta);
        }

        [HttpPut("{id}")]
        public Task<string> Put(string id, [FromBody] data.TbReceta receta)
        {
            return new BS.TbReceta().Updated(id, receta);
        }
        
        [HttpDelete("{id}")]
        public Task<string> Delete(string id)
        {
            return new BS.TbReceta().Delete(id);
        }


        [HttpGet("custom/{query}")]
        public Task<IEnumerable<DO.Objetos.TbReceta>> customQuery(string query)
        {
            return new BS.TbReceta().customQuery(query);
        }
    }
}