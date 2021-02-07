using System;
using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository.Maps
{
    public class ProdutoMap: BaseDomainMap<Produto>
    {
        ProdutoMap(): base("tb_produto") { }
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
        }
    }
}
