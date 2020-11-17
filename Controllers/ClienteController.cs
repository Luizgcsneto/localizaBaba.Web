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
            return Ok(_context.Clientes.ToList());
        }

        [HttpGet]
        public ActionResult<Cliente> Get(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult<Cliente> Post(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }

        [HttpPut]
        public ActionResult<Cliente> Put(Cliente cliente)
        {
            var clienteId = _context.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            clienteId.Nome = cliente.Nome;
            clienteId.SobreNome = cliente.SobreNome;
            clienteId.Senha = cliente.Senha;
            clienteId.Email = cliente.Email;
            _context.SaveChanges();
            return Ok(cliente);
        }

        [HttpDelete]
        public ActionResult<Cliente> Delete(int id)
        {
            var clienteId = _context.Clientes.FirstOrDefault(c => c.Id == id);
            _context.Remove(clienteId);
            _context.SaveChanges();
            return Ok(clienteId);

        }


    }
}
