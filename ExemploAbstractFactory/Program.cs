using ExemploAbstractFactory.AbstractFactory;
using ExemploAbstractFactory.Factory;
using System;

namespace ExemploAbstractFactory
{
    class Program
    {
        static void Main()
        {
            DbFactory conn = new OracleFactory();
            conn.CreateConnection().Open();
            conn.CreateCommand().Execute();

            Console.ReadKey();
        }
    }
}
