using localizaBaba.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace localizaBaba.Web.BD
{
    public class ConfigaurationCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData(
                 new Cliente()
                 {
                     Id = 1,
                     Nome = "Sebastião",
                     CPF = "000.000.000-01",
                     Email = "cliente@cliente.com",
                     Senha = "123456",
                     Endereco = "rua casas estaqui 123 bongi",
                     Cidade = "Recife",
                     Estado = "PE",
                     CEP = "0000-000"
                 }

              );
        }
    }
}
