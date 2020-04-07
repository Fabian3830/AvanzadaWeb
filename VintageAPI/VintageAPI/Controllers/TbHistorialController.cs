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

    [Route("Historial")]
    [ApiController]
    [Produces("application/json")]
    public class TbHistorialController : ControllerBase
    {
        [HttpGet]
        public Task<IEnumerable<DO.Objetos.TbHistorial>> Get()
        {
            return new BS.TbHistorial().GetAll();
        }

        [HttpGet("{id}")]
        public Task<DO.Objetos.TbHistorial> Get(string id)
        {
            return new BS.TbHistorial().GetOneById(id);
        }

        [HttpPost]
        public Task<string> Post([FromBody] data.TbHistorial historial)
        {
            return new BS.TbHistorial().Insert(historial);
        }

        [HttpPut("{id}")]
        public Task<string> Put(string id, [FromBody] data.TbHistorial historial)
        {
            return new BS.TbHistorial().Updated(id, historial);
        }

        [HttpDelete("{id}")]
        public Task<string> Delete(string id)
        {
            return new BS.TbHistorial().Delete(id);
        }
    }
}