using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using localizaBaba.Web.BD;
using localizaBaba.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace localizaBaba.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public UsuarioController()
        {

        }

        [HttpGet]
        public ActionResult Get()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                //var result = _repo.
                using (var bd = new BDContext())
                {
                    usuarios = bd.Usuarios.ToList();
                }
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            Usuario _usuario = new Usuario();
            using (var bd = new BDContext())
            {
                try
                {
                    var usuarioEncontrado = bd.Usuarios.Where(u => u.Email == usuario.Email).FirstOrDefault();


                    if (usuarioEncontrado != null)
                    {
                        return BadRequest("E-mail já sendo utilizado no sistema!");
                    }
                    else
                    {
                        _usuario.Nome = usuario.Nome;
                        _usuario.Email = usuario.Email;
                        _usuario.Senha = usuario.Senha;

                        var emailValido = ValidarEmail(_usuario.Email);
                        if (emailValido == false)
                        {
                            return BadRequest("E-mail formato inválido");
                        }

                        bd.Usuarios.Add(_usuario);
                        bd.SaveChanges();

                    }

                    return Ok(_usuario);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }


            }

        }

        public static bool ValidarEmail(string strEmail)
        {

            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
