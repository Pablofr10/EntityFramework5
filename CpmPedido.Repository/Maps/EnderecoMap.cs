﻿using CpmPedido.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedido.Repository
{
    public class EnderecoMap: BaseDomainMap<Endereco>
    {
        EnderecoMap() : base("tb_endereco") { }
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);

            _ = builder.Property(x => x.Tipo).HasColumnName("tipo").IsRequired();
            builder.Property(x => x.Logradouro).HasColumnName("logradouro").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Bairro).HasColumnName("bairro").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Numero).HasColumnName("numero").HasMaxLength(10);
            builder.Property(x => x.Complemento).HasColumnName("complemento").HasMaxLength(50);
            builder.Property(x => x.Cep).HasColumnName("cep").HasMaxLength(8);
        }
    }
}
