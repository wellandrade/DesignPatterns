using System.Collections.Generic;

namespace ExemploFacade.Classes
{
    public class Venda
    {
        public string NomeCliente { get; private set; }

        public IList<VendaItem> Itens { get; private set; }

        public Venda(string nomeCliente)
        {
            NomeCliente = nomeCliente;
            Itens = new List<VendaItem>();
        }

        public void AdicionarItem(VendaItem item)
        {
            Itens.Add(item);
        }
    }
}
