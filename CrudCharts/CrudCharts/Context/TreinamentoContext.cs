using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrudCharts.Models
{
    public partial class TreinamentoContext : DbContext
    {
        public TreinamentoContext()
        {
        }

        public TreinamentoContext(DbContextOptions<TreinamentoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<PedidoFrete> PedidoFrete { get; set; }
        public virtual DbSet<Rotas> Rotas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("User ID=postgres;Password=root;Host=localhost;Port=5432;Database=Treinamento;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Usuario).IsRequired();
            });

            modelBuilder.Entity<PedidoFrete>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Rotas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UfDestino).IsRequired();

                entity.Property(e => e.UfOrigem).IsRequired();
            });
        }
    }
}
