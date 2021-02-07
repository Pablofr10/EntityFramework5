using System;
using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class PedidoMap: BaseDomainMap<Pedido>
    {
        PedidoMap(): base("tb_pedido") { }
        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
        }
    }
}
