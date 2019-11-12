using Microsoft.EntityFrameworkCore;
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
    }
}
