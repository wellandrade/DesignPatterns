using ExemploAdapter.Interfaces;

namespace ExemploAdapter.Service
{
    // Cliente 
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransacao()
        {
            _logger.Log("Transacao realizada");
        }
    }
}
