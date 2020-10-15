using ExemploObserver.Classes;

namespace ExemploObserver.Interface
{
    public interface IObserver
    {
        string Nome { get; set; }

        void Notificar(Investimento investimento);
    }
}
