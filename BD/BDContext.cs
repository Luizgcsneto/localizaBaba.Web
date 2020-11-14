using localizaBaba.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace localizaBaba.Web.BD
{
    public class BDContext : DbContext
    {
        public BDContext() { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Baba> Babas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }

            IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
          .AddJsonFile("appsettings.json")
          .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ConfigurationUsuario());
            modelBuilder.ApplyConfiguration(new ConfigarationBaba());
            modelBuilder.ApplyConfiguration(new ConfigaurationCliente());

        }
    }
}
