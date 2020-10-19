using ExemploAbstractFactory.AbstractProduct;
using System;

namespace ExemploAbstractFactory.ProductConcrete
{
    // Product concrete 
    public class OracleCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Comando no oracleCommando foi executado");
        }
    }
}
