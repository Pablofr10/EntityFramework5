using System;
using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository.Maps
{
    public class ImagemMap: BaseDomainMap<Imagem>
    {
        ImagemMap(): base("tb_imagem") { }
        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
        }
    }
}
