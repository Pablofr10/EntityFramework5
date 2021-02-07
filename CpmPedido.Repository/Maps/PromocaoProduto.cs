using System;
using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository.Maps
{
    public class PromocaoProdutoMap: BaseDomainMap<PromocaoProduto>
    {
        PromocaoProdutoMap(): base("tb_promocao_produto") { }
        public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
        }
    }
}
