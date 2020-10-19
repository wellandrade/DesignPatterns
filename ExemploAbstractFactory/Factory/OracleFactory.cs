using ExemploAbstractFactory.AbstractFactory;
using ExemploAbstractFactory.AbstractProduct;
using ExemploAbstractFactory.ProductConcrete;

namespace ExemploAbstractFactory.Factory
{
    public class OracleFactory : DbFactory
    {
        public override DbCommand CreateCommand()
        {
            return new OracleCommand();
        }

        public override DbConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
