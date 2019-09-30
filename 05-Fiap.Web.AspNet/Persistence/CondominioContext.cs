using _05_Fiap.Web.AspNet.Controllers;
using _05_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Persistence
{
    public class CondominioContext : DbContext
    {

        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Construtora> Construtoras { get; set; }
        public DbSet<Sindico> Sindicos { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar as chaves primária da tabelas
            modelBuilder.Entity<CondominioConstrutora>()
                .HasKey(c => new { c.ConstrutoraId, c.CondominioId });

            //Configurar os relacionamento com o Condominio
            modelBuilder.Entity<CondominioConstrutora>()
                .HasOne(c => c.Condominio)
                .WithMany(c => c.CondominioConstrutoras)
                .HasForeignKey(c => c.CondominioId);

            modelBuilder.Entity<CondominioConstrutora>()
                .HasOne(c => c.Construtora)
                .WithMany(c => c.CondominioConstrutoras)
                .HasForeignKey(c => c.ConstrutoraId);

            base.OnModelCreating(modelBuilder);
        }

        public CondominioContext(DbContextOptions options) : base(options) {}


    }
}
