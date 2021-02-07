using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class EnderecoMap: BaseDomainMap<Endereco>
    {
        EnderecoMap(): base("tb_endereco") { }
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);
        }
    }
}
