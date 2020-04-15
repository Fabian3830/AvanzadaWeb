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

    [Route("Cliente")]
    [ApiController]
    [Produces("application/json")]
    public class TbClienteController : ControllerBase
    {
        [HttpGet]
        public Task<IEnumerable<DO.Objetos.TbCliente>> Get()
        {
            return new BS.TbCliente().GetAll();
        }

        [HttpGet("{id}")]
        public Task<DO.Objetos.TbCliente> Get(string id)
        {
            return new BS.TbCliente().GetOneById(id);
        }

        [HttpPost]
        public Task<string> Post([FromBody] data.TbCliente cliente)
        {
            return new BS.TbCliente().Insert(cliente);
        }

        [HttpPut("{id}")]
        public Task<string> Put(string id, [FromBody] data.TbCliente cliente)
        {
            return new BS.TbCliente().Updated(id, cliente);
        }

        [HttpDelete("{id}")]
        public Task<string> Delete(string id)
        {
            return new BS.TbCliente().Delete(id);
        }

        [HttpPost("/login")]
        public Task<DO.Objetos.TbCliente> Login([FromBody] data.credentials credential)
        {
            return new BS.TbCliente().Verify(credential);
        }
        [HttpGet("/ver/{id}/{idR}")]
        public async Task<bool> clientever(string id,string idR)
        {
            DO.Objetos.TbReceta receta= await new BS.TbReceta().GetOneById(id);
            if (receta==null) return false;
            if (receta.iPrecio==0) return true;
            if (id == "_") return false;

            DO.Objetos.TbCliente cliente =await new BS.TbCliente().GetOneById(id);

            for (int i = 0; i < cliente.aRecetas.Length; i++) if (cliente.aRecetas[i]==idR) return true;
            
            
            return false;
        }


        [HttpGet("custom/{query}")]
        public Task<IEnumerable<DO.Objetos.TbCliente>> customQuery(string query)
        {
            return new BS.TbCliente().customQuery(query);
        }


    }
}