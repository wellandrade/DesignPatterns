using ExemploAdapter.Interfaces;
using System;

namespace ExemploAdapter.Classes
{
    public class LoggerCustomizado : ILoggerCustomizado
    {
        public void LogDeuBom(string mensagem)
        {
            Console.WriteLine($"Log customizado - { mensagem }");
        }

        public void LogDeuRuim(Exception exception)
        {
            Console.WriteLine($"Log customizado - { exception.Message}");
        }
    }
}
