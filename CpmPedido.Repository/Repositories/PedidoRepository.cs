using System;
using System.Linq;
using CpmPedido.Interface.Repositories;

namespace CpmPedido.Repository
{
    public class PedidoRepository : BaseRepository, IPedidoRepository
    { 
        public PedidoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public decimal TicketMaximo()
        {
            var hoje = DateTime.Today;

            return DbContext.Pedidos
                .Where(x => x.CriadoEm.Date == hoje)
                .Max(x => (decimal?)x.ValorTotal) ?? 0;
        }
    }
}
