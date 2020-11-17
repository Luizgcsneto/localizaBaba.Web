using localizaBaba.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace localizaBaba.Web.BD
{
    public class ConfigarationBaba : IEntityTypeConfiguration<Baba>
    {
        public void Configure(EntityTypeBuilder<Baba> builder)
        {
            builder.HasData(
               new Baba()
               {
                   Id = 1,
                   Nome = "Novo Baba",
                   Email = "baba@baba.com",
                   Senha = "123456"
               }

            );
        }
    }
}
