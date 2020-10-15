using ExemploAdapter.Interfaces;
using System;

namespace ExemploAdapter.Classes
{
    // Adapter 
    public class LogAdapter : ILogger
    {
        private readonly ILoggerCustomizado _loggerCustomizado;

        public LogAdapter(ILoggerCustomizado loggerCustomizado)
        {
            _loggerCustomizado = loggerCustomizado;
        }

        public void Log(string mensagem)
        {
            _loggerCustomizado.LogDeuBom("Deu bom...");
        }

        public void LogError(Exception exception)
        {
            Exception ex = new Exception("Deu ruim");

            _loggerCustomizado.LogDeuRuim(ex);
        }
    }
}
