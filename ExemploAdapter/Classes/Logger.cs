using ExemploAdapter.Interfaces;
using System;

namespace ExemploAdapter.Classes
{
    // Target class 
    public class Logger : ILogger
    {
        public void Log(string mensagem)
        {
            Console.WriteLine($"Log padrao - { mensagem }");
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine($"Log padrao - { exception.Message }");
        }
    }
}
