using localizaBaba.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace localizaBaba.Web.BD
{
    public class ConfigurationBaba : IEntityTypeConfiguration<Baba>
    {
        public void Configure(EntityTypeBuilder<Baba> builder)
        {
            builder.HasData(
               new Baba()
               {
                   Id = 1,
                   Nome = "Josefina",
                   CPF = "000.000.000-00",
                   Email = "baba@baba.com",
                   Senha = "123456",
                   Endereco = "rua casas bahia 123 santo amaro",
                   Cidade = "Recife",
                   Estado = "PE",
                   CEP = "xxxxx-xxx"
               }

            );
        }
    }
}
