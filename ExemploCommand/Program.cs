using ExemploCommand.Classes;
using System;
using System.Threading;

namespace ExemploCommand
{
    class Program
    {
        /* 
            Quando é necessário trabalhar com vários eventos, várias chamadas por ação
            Toda a ação da vai ficar dentro do método execute, que é definido na interface Command 
        */

        static void Main()
        {
            var maquina = new MaquinaLavar();
            new LigarMaquinaCommand(maquina).Executar();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            new DesligarMaquinaCommand(maquina).Executar();

            Console.ReadKey();
        }
    }
}
