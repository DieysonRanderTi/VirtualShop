using System;
using System.Collections.Generic;
using System.Linq;
using VirtualShop.Repositorio.Contexto;
using VitualShop.Dominio.Contratos;

namespace VirtualShop.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly VirtualShopContexto VirtualShopContexto;


        public BaseRepositorio(VirtualShopContexto virtualShopContexto)
        {
            VirtualShopContexto = virtualShopContexto;

        }
        public void Adicionar(TEntity entity)
        {
            VirtualShopContexto.Set<TEntity>().Add(entity);
            VirtualShopContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            VirtualShopContexto.Set<TEntity>().Update(entity);
            VirtualShopContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return VirtualShopContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return VirtualShopContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            VirtualShopContexto.Remove(entity);
            VirtualShopContexto.SaveChanges();
        }

        public void Dispose()
        {
            VirtualShopContexto.Dispose();
        }
    }
}
