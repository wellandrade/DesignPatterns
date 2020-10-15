using ExemploFactoryMethod.Classes.AbstractProduct;
using System;

namespace ExemploFactoryMethod.Classes.ConcrectProduct
{
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string stringConexao) 
            : base(stringConexao) 
        {

        }

        public override ConexaoBanco Conectar()
        {
            Console.WriteLine("Conectando ao banco Oracle");
            var conexao = new ConexaoBanco(_stringConexao);
            conexao.Abrir();

            return conexao;
        }
    }
}
