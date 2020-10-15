using ExemploAdapter.Classes;
using ExemploAdapter.Service;
using System;

namespace ExemploAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* OBS: Resolver por Injeção de dependencia */
            var transacaoComLogPadrao = new TransacaoService(new Logger());
            transacaoComLogPadrao.RealizarTransacao();

            /* A classe TransacaoService não pode ser alterada, por n motivos e ela recebe a interface iLogger no seu construtor
                para utilização do log customizado, deve criar uma classe de adaptação (LogAdapter) implementando a mesma interface iLogger, porém essa classe (LogAdapter)
                vai usar a logCustomizado por baixo dos panos, para fazer a gravação do novo de um novo jeito.
               Dessa maneira a classe TransacaoService não foi alterada, manteve seu funcionamento e estará utilizando um outro objeto para fazer uma coisa de outra forma 
             */

            var transacaoComLogPadronizado = new TransacaoService(new LogAdapter(new LoggerCustomizado()));
            transacaoComLogPadronizado.RealizarTransacao();

            Console.ReadKey();
        }
    }
}
