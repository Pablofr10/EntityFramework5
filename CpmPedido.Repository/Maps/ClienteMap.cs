using System;
using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class ClienteMap: BaseDomainMap<Cliente>
    {
        ClienteMap(): base("tb_cliente") { }
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
        }
    }
}
