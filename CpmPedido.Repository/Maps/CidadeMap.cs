using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class CidadeMap: BaseDomainMap<Cidade>
    {
        CidadeMap(): base("tb_cidade") { }

        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            base.Configure(builder);
        }
    }
}
