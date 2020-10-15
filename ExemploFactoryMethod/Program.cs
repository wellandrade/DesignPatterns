using ExemploFactoryMethod.Classes.FactoryMethod;
using ExemploFactoryMethod.Enum;
using System;

namespace ExemploFactoryMethod
{
    class Program
    {
        /* Disponibilzar uma interface que vai ajudar a criar um tipo especifico de produto
           A classe que estiver usando essa interface vai falar qual produto deseja criar 
            desse forma acaba abstraindo a complexidade da criacao de algum objeto, basta informar somente o tipo do objeto que ele vai ser criado  
        */

        static void Main()
        {
            var sql = DbFactory.BancoDados(EDataBase.SQL_SERVER).CriarConexao("conexaoSQL").Conectar();
            sql.ExecutarCommand("select * from table");
            sql.Fechar();

            var oracle = DbFactory.BancoDados(EDataBase.ORACLE).CriarConexao("conexaoOracle").Conectar();
            oracle.ExecutarCommand("select * from table");
            oracle.Fechar();

            var mongoDB = DbFactory.BancoDados(EDataBase.MONGO_DB).CriarConexao("conexaomONGO").Conectar();
            mongoDB.ExecutarCommand("select * from table");
            mongoDB.Fechar();

            Console.ReadKey();
        }
    }
}
