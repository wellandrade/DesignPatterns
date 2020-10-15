﻿using ExemploStrategy.Classes;
using ExemploStrategy.Interface;

namespace ExemploStrategy.Service
{
    public class PagamentoBoleto : IPagamento
    {
        public string RealizarPagamento(Pagamento pagamento)
        {
            return "Pago com boleto";
        }
    }
}
