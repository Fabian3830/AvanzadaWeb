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

    [Route("Factura")]
    [ApiController]
    [Produces("application/json")]
    public class TbFacturaController : ControllerBase
    {
        [HttpGet]
        public Task<IEnumerable<DO.Objetos.TbFactura>> Get()
        {
            return new BS.TbFactura().GetAll();
        }

        [HttpGet("{id}")]
        public Task<DO.Objetos.TbFactura> Get(string id)
        {
            return new BS.TbFactura().GetOneById(id);
        }

        [HttpPost]
        public Task<string> Post([FromBody] data.TbFactura factura)
        {
            return new BS.TbFactura().Insert(factura);
        }

        [HttpPut("{id}")]
        public Task<string> Put(string id, [FromBody] data.TbFactura factura)
        {
            return new BS.TbFactura().Updated(id, factura);
        }

        [HttpDelete("{id}")]
        public Task<string> Delete(string id)
        {
            return new BS.TbFactura().Delete(id);
        }
    }
}