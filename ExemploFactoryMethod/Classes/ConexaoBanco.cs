using System;

namespace ExemploFactoryMethod.Classes
{
    public class ConexaoBanco
    {
        private string _stringConexao { get; set; }

        private bool _conexaoAberta { get; set; }

        public ConexaoBanco(string stringConexao)
        {
            _stringConexao = stringConexao;
        }

        public void ExecutarCommand(string comando)
        {
            Console.WriteLine($"Executar o comando { comando }");
        }

        public void Abrir()
        {
            _conexaoAberta = true;
            Console.WriteLine("Conexao aberta");
        }

        public void Fechar()
        {
            _conexaoAberta = false;
            Console.WriteLine("Conexao fechada");
        }
    }
}
