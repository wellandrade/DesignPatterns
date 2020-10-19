using ExemploAbstractFactory.AbstractProduct;
using System;

namespace ExemploAbstractFactory.ProductConcrete
{
    // Product concrete 
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Conexao do SqlConnection foi aberta");
        }
    }
}
