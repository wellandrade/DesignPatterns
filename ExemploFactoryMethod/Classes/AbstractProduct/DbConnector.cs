namespace ExemploFactoryMethod.Classes.AbstractProduct
{
    // Abstract Product 
    public abstract class DbConnector
    {
        public string _stringConexao { get; private set; }

        protected DbConnector(string stringConexao)
        {
            _stringConexao = stringConexao;
        }

        public abstract ConexaoBanco Conectar();

    }
}
