using ExemploFactoryMethod.Classes.AbstractProduct;
using ExemploFactoryMethod.Classes.ConcreteCreator;
using ExemploFactoryMethod.Enum;
using System;

namespace ExemploFactoryMethod.Classes.FactoryMethod
{
    // Abstract Creator
    public abstract class DbFactory
    {
        // Factory Method
        public abstract DbConnector CriarConexao(string stringConexao);

        public static DbFactory BancoDados(EDataBase eDataBase)
        {
            switch (eDataBase)
            {
                case EDataBase.SQL_SERVER:
                    return new SqlFactory();
                case EDataBase.ORACLE:
                    return new OracleFactory();
                case EDataBase.MONGO_DB:
                    return new MongoFactory();
                default:
                    throw new ApplicationException("Bando de dados nao reconhecido");
            }

        }
    }
}
