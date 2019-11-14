using Microsoft.EntityFrameworkCore;
using VirtualShop.Repositorio.Config;
using VitualShop.Dominio.Entidades;
using VitualShop.Dominio.Entidades.ObjetoDeValor;

namespace VirtualShop.Repositorio.Contexto
{
    public class VirtualShopContexto: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }

        public VirtualShopContexto(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(

            new FormaPagamento()
            {
                Id = 1,
                Nome = "Boleto",
                Descricao = "Forma de pagamento Boleto"
            },
            new FormaPagamento()
            {
                Id = 2,
                Nome = "Depósito",
                Descricao = "Forma de pagamento Depósito"
            },
            new FormaPagamento()
            {
                Id = 3,
                Nome = "Cartão de Crédito",
                Descricao = "Forma de pagamento Cartão de Crédito"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
