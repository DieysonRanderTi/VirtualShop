using System;
using System.Collections.Generic;
using System.Text;
using VirtualShop.Repositorio.Contexto;
using VitualShop.Dominio.Contratos;
using VitualShop.Dominio.Entidades;

namespace VirtualShop.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(VirtualShopContexto virtualShopContexto) : base(virtualShopContexto)
        {
        }
    }
}
