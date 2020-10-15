using ExemploObserver.Interface;
using System;

namespace ExemploObserver.Classes
{
    public class Observador : IObserver
    {
        public Observador(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public void Notificar(Investimento investimento)
        {
            Console.WriteLine("Notificando {0} que {1} teve o preço alterado para {2:C}", Nome, investimento.Simbolo, investimento.Valor);
        }
    }
}
