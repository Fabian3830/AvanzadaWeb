using System;
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
    public class TbRecetaController : ControllerBase
    {
        [HttpGet]
        public Task<string> Get()
        {
            return new BS.TbReceta().GetAll();
        }

        [HttpGet("{id}")]
        public Task<string> Get(string id)
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
    }
}