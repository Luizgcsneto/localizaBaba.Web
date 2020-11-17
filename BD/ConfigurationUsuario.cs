using localizaBaba.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace localizaBaba.Web.BD
{
    public class ConfigurationUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasData(
                  new Usuario()
                  {
                      Id = 1,
                      Nome = "Luiz",
                      Email = "luiz@rkcomex.com",
                      Senha = "123456"
                  }

               );
        }
    }
}
