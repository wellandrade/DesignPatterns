using ExemploCommand.Interfaces;
using System;

namespace ExemploCommand.Classes
{
    public class DesligarMaquinaCommand : ICommand
    {
        private readonly MaquinaLavar _maquinaLavar;

        public DesligarMaquinaCommand(MaquinaLavar maquinaLavar)
        {
            _maquinaLavar = maquinaLavar;
        }

        public void Executar()
        {
            _maquinaLavar.Desligar();
            _maquinaLavar.FecharTorneira();
            Console.WriteLine("Maquina desligada e torneira fechada");
        }

    }
}
