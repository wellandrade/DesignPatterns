using ExemploStrategy.Classes;
using ExemploStrategy.Interface;

namespace ExemploStrategy.Service
{
    public class PagamentoCredito : IPagamento
    {
        public string RealizarPagamento(Pagamento pagamento)
        {
            return "Pago com credito";
        }
    }
}
