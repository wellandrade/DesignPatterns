using ExemploFacade.Classes;
using ExemploFacade.Interface;
using ExemploFacade.Repositorios;
using System;

namespace ExemploFacade
{
    class Program
    {
        static void Main()
        {
            /* Resolver com DI no mundo real */
            IVendaFacade vendaFacade = new VendaFacade(new VendaRepositorio(), new VendaItemRepositorio());

            Venda venda = new Venda("Cliente teste");
            venda.AdicionarItem(new VendaItem(1, 2, 10M));
            venda.AdicionarItem(new VendaItem(5, 10, 20M));

            /* Usando o facade de fato, centralizar todo o processo de venda em somente um unico lugar
               Nao nos preocupamos com o que existe no método InserirVenda, se ele usa 1 ou N repositorio, como somente um ponto para efetuar venda 
                facilita a manutencao futuramente 
            */

            var efetuouVenda = vendaFacade.InserirVenda(venda);

            if (efetuouVenda != null)
            {
                Console.WriteLine("Venda cadastrada com sucesso");
            }
            else
            {
                Console.WriteLine("Falha ao cadastra venda");
            }

            Console.ReadKey();
        }
    }
}
