using QuickBuy.Domain.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int NumeroEndereco { get; set; }
        public string EnderecoCompleto { get; set; }

        public int FormaDePagamentoId { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("CEP deve estar preenchido.");

        }
    }
}
