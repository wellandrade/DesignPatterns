using ExemploSingleton.Classes;
using System;

namespace ExemploSingleton
{
    class Program
    {
        // Client 
        static void Main()
        {
            var conexao = ConexaoDB.Instance();
            conexao.Open();

            var novaConexao = ConexaoDB.Instance();
            novaConexao.Open();

            Console.ReadKey();
        }
    }
}
