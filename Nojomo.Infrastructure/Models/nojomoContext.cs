using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Models
{
    public partial class nojomoContext : DbContext
    {
        public nojomoContext()
        {
        }

        public nojomoContext(DbContextOptions<nojomoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cestaproducto> Cestaproductos { get; set; }
        public virtual DbSet<Cestum> Cesta { get; set; }
        public virtual DbSet<Cuentaspago> Cuentaspagos { get; set; }
        public virtual DbSet<Datosfiscale> Datosfiscales { get; set; }
        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Orden> Ordens { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cestaproducto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cestum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cuentaspago>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Datosfiscale>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Orden>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

           
        }

       
    }
}
