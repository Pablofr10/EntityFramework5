using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class ProdutoPedidoMap: BaseDomainMap<ProdutoPedido>
    {
        ProdutoPedidoMap(): base("tb_produto_pedido") { }
        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);
        }
    }
}
