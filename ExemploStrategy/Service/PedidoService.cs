using ExemploStrategy.Classes;
using ExemploStrategy.Interface;

namespace ExemploStrategy.Service
{
    public class PedidoService
    {
        private readonly IPagamento _pagamento;

        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public string RealizarPagamento(Pagamento pagamento)
        {
            return _pagamento.RealizarPagamento(pagamento);
        }
    }
}
