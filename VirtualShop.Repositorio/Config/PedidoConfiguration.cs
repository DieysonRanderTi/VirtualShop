﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VitualShop.Dominio.Entidades;

namespace VirtualShop.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(p => p.Cep)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(50);

       

        }
    }
}
