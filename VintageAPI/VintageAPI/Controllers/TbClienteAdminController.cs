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

    [Route("Admin")]
    [ApiController]
    public class TbClienteAdminController : ControllerBase
    {
        [HttpPost]
        public Task<string> Post([FromBody] data.TbCliente admin)
        {
            admin.bAdmin = true;
            return new BS.TbCliente().Insert(admin);
        }
    }
}