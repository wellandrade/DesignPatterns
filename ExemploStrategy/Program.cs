using ExemploStrategy.Classes;
using ExemploStrategy.Enum;
using ExemploStrategy.Service;
using System;

namespace ExemploStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoDebito = new Pagamento
            {
                Valor = 200,
                MeioPagamento = EMeioPagamento.DEBITO
            };

            var pagamentoCredito = new Pagamento
            {
                Valor = 200,
                MeioPagamento = EMeioPagamento.CARTAO_CREDITO
            };

            var pagamentoDinheiro = new Pagamento
            {
                Valor = 50,
                MeioPagamento = EMeioPagamento.DINHEIRO
            };

            var pedidoService = new PedidoService(new PagamentoBoleto());
            Console.WriteLine(pedidoService.RealizarPagamento(pagamentoDebito));

            pedidoService = new PedidoService(new PagamentoCredito());
            Console.WriteLine(pedidoService.RealizarPagamento(pagamentoCredito));

            pedidoService = new PedidoService(new PagamentoDinheiro());
            Console.WriteLine(pedidoService.RealizarPagamento(pagamentoDinheiro));

            Console.ReadKey();
        }
    }
}
