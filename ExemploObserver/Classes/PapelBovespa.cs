namespace ExemploObserver.Classes
{
    // Concrete Subject
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal valor) 
            : base(simbolo, valor)
        {
        }
    }
}
