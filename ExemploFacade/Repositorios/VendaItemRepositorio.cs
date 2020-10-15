using ExemploFacade.Classes;
using ExemploFacade.Interfaces;

namespace ExemploFacade.Repositorios
{
    public class VendaItemRepositorio : IVendaItemRepositorio
    {
        public VendaItem InserirItem(Venda venda, VendaItem vendaItem)
        {
            return new VendaItem(vendaItem.IdProduto, vendaItem.Quantidade, vendaItem.Desconto);
        }
    }
}
