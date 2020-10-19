using ExemploAbstractFactory.AbstractProduct;
using System;

namespace ExemploAbstractFactory.ProductConcrete
{
    public class OracleConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Conexao do oracleConnection foi aberta");
        }
    }
}
