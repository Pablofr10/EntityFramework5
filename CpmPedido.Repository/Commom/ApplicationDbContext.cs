using System;
using Microsoft.EntityFrameworkCore;

namespace CpmPedido.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public ApplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
