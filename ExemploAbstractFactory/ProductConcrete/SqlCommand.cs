using ExemploAbstractFactory.AbstractProduct;
using System;

namespace ExemploAbstractFactory.ProductConcrete
{
    // Product concrete 
    public class SqlCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Comando no sqlCommando foi executado");
        }
    }
}
