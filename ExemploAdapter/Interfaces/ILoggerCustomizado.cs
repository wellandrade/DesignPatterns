using System;

namespace ExemploAdapter.Interfaces
{
    public interface ILoggerCustomizado
    {
        void LogDeuBom(string mensagem);
        void LogDeuRuim(Exception exception);
    }
}
