using System;

namespace ExemploAdapter.Interfaces
{
    public interface ILogger
    {
        void Log(string mensagem);
        void LogError(Exception exception);
    }
}
