using ExemploCommand.Interfaces;
using System;

namespace ExemploCommand.Classes
{
    public class LigarMaquinaCommand : ICommand
    {
        private MaquinaLavar _maquinaLavar;

        public LigarMaquinaCommand(MaquinaLavar maquinaLavar)
        {
            _maquinaLavar = maquinaLavar;
        }

        public void Executar()
        {
            _maquinaLavar.AbrirTorneira();
            _maquinaLavar.Ligar();
            Console.WriteLine("Torneira aberta e maquina ligada");
        }
    }
}
