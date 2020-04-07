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

    [Route("Categoria")]
    [ApiController]
    public class TbCategoriaController : ControllerBase
    {
        [HttpGet]
        public Task<IEnumerable<DO.Objetos.TbCategoria>> Get()
        {
            return new BS.TbCategoria().GetAll();
        }

        [HttpGet("{id}")]
        public Task<string> Get(string id)
        {
            return new BS.TbCategoria().GetOneById(id);
        }

        [HttpPost]
        public Task<string> Post([FromBody] data.TbCategoria categoria)
        {
            return new BS.TbCategoria().Insert(categoria);
        }

        [HttpPut("{id}")]
        public Task<string> Put(string id, [FromBody] data.TbCategoria categoria)
        {
            return new BS.TbCategoria().Updated(id, categoria);
        }

        [HttpDelete("{id}")]
        public Task<string> Delete(string id)
        {
            return new BS.TbCategoria().Delete(id);
        }
    }
}