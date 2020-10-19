using System;

namespace ExemploSingleton.Classes
{
    // Singleton 
    public class ConexaoDB
    {
        private static ConexaoDB _instance;

        // Esconde o construtor, dessa forma nao vai deixar instanciar 
        protected ConexaoDB() { }

        // Metodo que vai retornar singleton 
        public static ConexaoDB Instance()
        {
            if (_instance == null)
            {
                _instance = new ConexaoDB();
            }

            return _instance;
        }

        public void Open()
        {
            Console.WriteLine("Abrindo conexao");
        }
    }
}
