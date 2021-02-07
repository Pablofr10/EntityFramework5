using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class PromocaoProdutoMap: BaseDomainMap<PromocaoProduto>
    {
        PromocaoProdutoMap(): base("tb_promocao_produto") { }
        public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            base.Configure(builder);
        }
    }
}
