using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BS;
using data = DAL.MODEL;

namespace VintageAPI.Controllers
{
  
    [Route("api/TbArticulo")]
    [ApiController]
    public class TbArticuloController : ControllerBase
    {
        //[Route("api/TbArticulo/GetAll")]
        [HttpGet]
        public Task<string> Get()
        {
            return new BS.TbArticulo().GetAll();
        }

        //[Route("api/TbArticulo/GetOneById")]
        [HttpGet("{id}")]
        public Task<string> Get(string id)
        {
            return new BS.TbArticulo().GetOneById(id);
        }

        //[Route("api/TbArticulo/Insert")]
        [HttpPost]
        public Task<string> Post([FromBody] data.TbArticulo articulo)
        {
            return new BS.TbArticulo().Insert(articulo);
        }

        //[Route("api/TbArticulo/Updated")]
        [HttpPut("{id}")]
        public Task<string> Put(string id, [FromBody] data.TbArticulo articulo)
        {
            return new BS.TbArticulo().Updated(id, articulo);
        }

        //[Route("api/TbArticulo/Delete")]
        [HttpDelete("{id}")]
        public Task<string> Delete(string id)
        {
            return new BS.TbArticulo().Delete(id);
        }
    }
}