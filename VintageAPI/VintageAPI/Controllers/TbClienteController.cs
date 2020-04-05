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

    [Route("Cliente")]
    [ApiController]
    public class TbClienteController : ControllerBase
    {
        [HttpGet]
        public Task<string> Get()
        {
            return new BS.TbCliente().GetAll();
        }

        [HttpGet("{id}")]
        public Task<string> Get(string id)
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
    }
}