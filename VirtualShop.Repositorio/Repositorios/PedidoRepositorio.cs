using System;
using System.Collections.Generic;
using System.Text;
using VirtualShop.Repositorio.Contexto;
using VitualShop.Dominio.Contratos;
using VitualShop.Dominio.Entidades;

namespace VirtualShop.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(VirtualShopContexto virtualShopContexto) : base(virtualShopContexto)
        {
        }
    }
}
