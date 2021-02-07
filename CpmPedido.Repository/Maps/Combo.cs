using System;
using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository.Maps
{
    public class ComboMap: BaseDomainMap<Combo>
    {
        ComboMap(): base("tb_combo") { }
        public override void Configure(EntityTypeBuilder<Combo> builder)
        {
        }
    }
}
