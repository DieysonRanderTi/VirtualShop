using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VitualShop.Dominio.Entidades.ObjetoDeValor;

namespace VitualShop.Dominio.Entidades
{
    public class Pedido: Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario{ get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Erro: Pedido não pode ficar sem Itens!.");

            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("Erro: Cep deve estar preenchido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Erro: Forma de pagamento não informada.");
        }
    }
}
