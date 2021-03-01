using QuickBuy.Domain.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entidades
{
    public class Pedido
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

        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
}
