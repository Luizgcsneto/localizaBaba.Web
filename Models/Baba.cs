﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace localizaBaba.Web.Models
{
    public class Baba
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }

        public Baba()
        {

        }
    }
}
