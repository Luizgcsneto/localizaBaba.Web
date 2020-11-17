using localizaBaba.Web.BD;
using localizaBaba.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace localizaBaba.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly BDContext _context;

        public ClienteController(BDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            return _context.Clientes.ToList();
        }

        [HttpGet]
        public ActionResult<Cliente> Get(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }



    }
}
