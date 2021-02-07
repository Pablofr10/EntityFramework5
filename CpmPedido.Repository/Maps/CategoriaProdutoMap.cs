using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class CategoriaProdutoMap: BaseDomainMap<CategoriaProduto>
    {
        CategoriaProdutoMap(): base("tb_categoria_produto") { }
        public override void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            base.Configure(builder);
        }
    }
}
