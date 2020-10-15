using ExemploFactoryMethod.Classes.AbstractProduct;
using System;

namespace ExemploFactoryMethod.Classes.ConcrectProduct
{
    // Concrect Product 
    public class SqlServerDbConnector : DbConnector
    {
        public SqlServerDbConnector(string stringConexao) 
            : base(stringConexao)
        {

        }

        public override ConexaoBanco Conectar()
        {
            Console.WriteLine("Conectando ao banco SQL Server");
            var conexao = new ConexaoBanco(_stringConexao);
            conexao.Abrir();

            return conexao;
        }
    }
}
