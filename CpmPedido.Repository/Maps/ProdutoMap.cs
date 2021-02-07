using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class ProdutoMap: BaseDomainMap<Produto>
    {
        ProdutoMap(): base("tb_produto") { }
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
        }
    }
}
