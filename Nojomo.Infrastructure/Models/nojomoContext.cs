using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Nojomo.Core.Entities;

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
        public virtual DbSet<Refreshtoken> Refreshtokens { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=nojomo;Username=postgres;Password=secret");
            }
        }

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

            modelBuilder.Entity<Refreshtoken>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("refreshtoken_pkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
