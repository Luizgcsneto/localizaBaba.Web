﻿using localizaBaba.Web.BD;
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
            try
            {
                var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        public ActionResult<Cliente> Post(Cliente cliente)
        {

            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost("VerificarCliente")]
        public ActionResult VerificarCliente([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente.Email == "luiz@gmail.com" && cliente.Senha == "123456")
                {
                    return Ok(cliente);
                }
                else
                {
                    return BadRequest("Cliente ou Senha inválida");
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
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
