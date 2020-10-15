using ExemploStrategy.Classes;
using ExemploStrategy.Interface;

namespace ExemploStrategy.Service
{
    public class PagamentoDinheiro : IPagamento
    {
        public string RealizarPagamento(Pagamento pagamento)
        {
            return "Pago com dinheiro";
        }
    }
}
