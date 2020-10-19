using ExemploAbstractFactory.AbstractFactory;
using ExemploAbstractFactory.AbstractProduct;
using ExemploAbstractFactory.ProductConcrete;

namespace ExemploAbstractFactory.Factory
{
    // Concrete factory 
    public class SqlFactory : DbFactory
    {
        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public override DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

    }
}
