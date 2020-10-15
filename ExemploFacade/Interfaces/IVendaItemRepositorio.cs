using ExemploFacade.Classes;

namespace ExemploFacade.Interfaces
{
    public interface IVendaItemRepositorio
    {
        VendaItem InserirItem(Venda venda, VendaItem vendaItem);
    }
}
