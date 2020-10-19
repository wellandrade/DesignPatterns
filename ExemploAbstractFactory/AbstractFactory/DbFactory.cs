using ExemploAbstractFactory.AbstractProduct;

namespace ExemploAbstractFactory.AbstractFactory 
{
    // Abstract factory 
    public abstract class DbFactory
    {
        public abstract DbConnection CreateConnection();

        public abstract DbCommand CreateCommand();
    }
}
