using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitualShop.Dominio.Entidades;

namespace VirtualShop.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {

            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(p => p.Preco)
                .IsRequired();

            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);
        }
    }
}
