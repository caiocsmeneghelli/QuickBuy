﻿using QuickBuy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.ObjetoDeValor
{
    public class FormaDePagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto { get { return Id == (int)TipoFormaPagamentoEnum.Boleto; } }
        public bool EhCartaoCredito { get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; } }
        public bool EhDeposito { get { return Id == (int)TipoFormaPagamentoEnum.Deposito; } }
        public bool NaoFoiDefinido { get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; } }

    }
}
