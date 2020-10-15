using ExemploFactoryMethod.Classes.AbstractProduct;
using ExemploFactoryMethod.Classes.ConcrectProduct;
using ExemploFactoryMethod.Classes.FactoryMethod;

namespace ExemploFactoryMethod.Classes.ConcreteCreator
{
    public class SqlFactory : DbFactory
    {
        public override DbConnector CriarConexao(string stringConexao)
        {
            return new SqlServerDbConnector(stringConexao);
        }
    }
}
