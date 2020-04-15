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
  
    [Route("Articulo")]
    [ApiController]
    [Produces("application/json")]
    public class TbArticuloController : ControllerBase
    {
        [HttpGet]
        public Task<IEnumerable<DO.Objetos.TbArticulo>> Get()
        {
            return new BS.TbArticulo().GetAll();
        }

        [HttpGet("{id}")]
        public Task<DO.Objetos.TbArticulo> Get(string id)
        {
            return new BS.TbArticulo().GetOneById(id);
        }

        [HttpPost]
        public Task<string> Post([FromBody] data.TbArticulo articulo)
        {
            return new BS.TbArticulo().Insert(articulo);
        }

        [HttpPut("{id}")]
        public Task<string> Put(string id, [FromBody] data.TbArticulo articulo)
        {
            return new BS.TbArticulo().Updated(id, articulo);
        }

        [HttpDelete("{id}")]
        public Task<string> Delete(string id)
        {
            return new BS.TbArticulo().Delete(id);
        }


        [HttpGet("custom/{query}")]
        public Task<IEnumerable<DO.Objetos.TbArticulo>> customQuery(string query)
        {
            return new BS.TbArticulo().customQuery(query);
        }


    }
}