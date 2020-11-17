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
                     Nome = "Novo Cliente",
                     Email = "cliente@cliente.com",
                     Senha = "123456"
                 }

              );
        }
    }
}
