using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VitualShop.Dominio.Entidades.ObjetoDeValor;

namespace VirtualShop.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder
                .HasKey(f => f.Id);

            builder
                .Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
