using ExemploStrategy.Classes;

namespace ExemploStrategy.Interface
{
    public interface IPagamento
    {
        string RealizarPagamento(Pagamento pagamento);
    }
}
