﻿using ExemploFactoryMethod.Classes.AbstractProduct;
using ExemploFactoryMethod.Classes.ConcrectProduct;
using ExemploFactoryMethod.Classes.FactoryMethod;

namespace ExemploFactoryMethod.Classes.ConcreteCreator
{
    class OracleFactory : DbFactory
    {
        public override DbConnector CriarConexao(string stringConexao)
        {
            return new OracleDbConnector(stringConexao);
        }
    }
}
