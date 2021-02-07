using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore;

namespace CpmPedido.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Imagem> Imagens { get; set; }
        public virtual DbSet<PromocaoProduto> PromocaoProdutos { get; set; }
        public virtual DbSet<Combo> Combos { get; set; }
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
