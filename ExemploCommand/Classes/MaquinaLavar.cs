using ExemploCommand.Interfaces;
using System;

namespace ExemploCommand.Classes
{
    public class MaquinaLavar : IEletrodomestico
    {
        private bool _energia;
        private bool _torneira;

        public MaquinaLavar()
        {
            _energia = false;
            _torneira = false;
        }

        public void Ligar()
        {
            if (!_torneira)
            {
                Console.Write("Abra a torneira antes de ligar.");
                return;
            }
            _energia = true;
        }

        public void Desligar()
        {
            _energia = false;
        }

        public void AbrirTorneira()
        {
            _torneira = true;
        }

        public void FecharTorneira()
        {
            if (_energia)
            {
                Console.WriteLine("Desligue a torneira antes de fechar");
            }
            _torneira = false;
        }
    }
}
