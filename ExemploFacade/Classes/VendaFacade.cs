using ExemploFacade.Interface;
using ExemploFacade.Interfaces;

namespace ExemploFacade.Classes
{
    public class VendaFacade : IVendaFacade
    {
        private readonly IVendaRepositorio _vendaRepository;
        private readonly IVendaItemRepositorio _vendaItemRepository;

        // Resolver por DI
        public VendaFacade(IVendaRepositorio vendaRepository, IVendaItemRepositorio vendaItemRepository)
        {
            _vendaRepository = vendaRepository;
            _vendaItemRepository = vendaItemRepository;
        }

        public Venda InserirVenda(Venda venda)
        {
            var vendaCadastrada = _vendaRepository.Inserir(venda);

            foreach (var item in venda.Itens)
            {
                vendaCadastrada.AdicionarItem(_vendaItemRepository.InserirItem(venda, item));
            }

            return vendaCadastrada;
        }
    }
}
