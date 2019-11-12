using System;
using System.Collections.Generic;
using System.Text;

namespace VitualShop.Dominio.Entidades
{
    public class ItemPedido: Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Produto não encontrado.");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não informada.");
        }
    }
}
