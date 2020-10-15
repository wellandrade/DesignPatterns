using ExemploComposite.Interfaces;
using System.Collections.Generic;

namespace ExemploComposite.Classes
{
    public class Mensagem : IMensagem
    {
        private readonly List<IMensagem> _listaDeMensagens = new List<IMensagem>();

        public string Nome { get; set; }

        public Mensagem(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagem(int sub)
        {
            throw new System.NotImplementedException();
        }
    }
}
