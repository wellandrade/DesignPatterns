using ExemploFactoryMethod.Classes.AbstractProduct;
using System;

namespace ExemploFactoryMethod.Classes.ConcrectProduct
{
    public class MongoDbConnector : DbConnector
    {
        public MongoDbConnector(string stringConexao) : base(stringConexao)
        {

        }

        public override ConexaoBanco Conectar()
        {
            Console.WriteLine("Conectando ao banco Mongo");
            var conexao = new ConexaoBanco(_stringConexao);
            conexao.Abrir();

            return conexao;
        }
    }
}
