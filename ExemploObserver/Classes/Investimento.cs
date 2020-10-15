using ExemploObserver.Interface;
using System;
using System.Collections.Generic;

namespace ExemploObserver.Classes
{
    // Subject 
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly IList<IObserver> _listaObserver = new List<IObserver>();

        public Investimento(string simbolo, decimal valor)
        {
            _valor = valor;
            Simbolo = simbolo;
        }

        public string Simbolo { get; set; }

        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) 
                    return;

                _valor = value;
                Notificar();
            }
        }

        public void Subscribe(IObserver observer)
        {
            _listaObserver.Add(observer);
            Console.WriteLine($"Notificando que { observer.Nome } está recebendo atualização do simbolo { Simbolo}");
        }

        public void UnSubcribe(IObserver observer)
        {
            _listaObserver.Remove(observer);
            Console.WriteLine($"Notificando que { observer.Nome } não está recebendo atualização do simbolo { Simbolo}");
        }

        private void Notificar()
        {
            foreach (var item in _listaObserver)
            {
                item.Notificar(this);
            }
            Console.WriteLine("");
        }
            
    }
}
