using ExemploFactoryMethod.Classes.AbstractProduct;
using ExemploFactoryMethod.Classes.ConcrectProduct;
using ExemploFactoryMethod.Classes.FactoryMethod;

namespace ExemploFactoryMethod.Classes.ConcreteCreator
{
    class MongoFactory : DbFactory
    {
        public override DbConnector CriarConexao(string stringConexao)
        {
            return new MongoDbConnector(stringConexao);
        }
    }
}
