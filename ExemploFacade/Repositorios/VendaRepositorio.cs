using ExemploFacade.Classes;
using ExemploFacade.Interfaces;

namespace ExemploFacade.Repositorios
{
    public class VendaRepositorio : IVendaRepositorio
    {
        public Venda Inserir(Venda venda)
        {
            return new Venda(venda.NomeCliente);
        }
    }
}
