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

        [Route("{id}")]
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
            clienteId.CPF = cliente.CPF;
            clienteId.Senha = cliente.Senha;
            clienteId.Email = cliente.Email;
            clienteId.Endereco = cliente.Endereco;
            clienteId.Cidade = cliente.Cidade;
            clienteId.Estado = cliente.Estado;
            clienteId.CEP = cliente.CEP;
            _context.SaveChanges();
            return Ok(cliente);
        }
        [Route("{id}")]
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
