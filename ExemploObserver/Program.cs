using ExemploObserver.Classes;
using System;

namespace ExemploObserver
{
    class Program
    {
        static void Main()
        {
            /* Para fazer observacao e notificacao toda vez que ocorrer alguma alteracao em algum valor da classe */

            var joao = new Observador("Joao");
            var bill = new Observador("Bill");

            var amazon = new PapelBovespa("Amazon", ProximoNumero());
            var microsoft = new PapelBovespa("Microsoft", ProximoNumero());

            amazon.Subscribe(joao);
            amazon.Subscribe(bill);

            microsoft.Subscribe(joao);
            microsoft.Subscribe(bill);


            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Valor = ProximoNumero();
                microsoft.Valor = ProximoNumero();
            }

            Console.ReadKey();
        }

        public static decimal ProximoNumero()
        {
            var random = new Random().Next(141421, 314160);
            return random / (decimal)100000.00;
        }
    }
}
