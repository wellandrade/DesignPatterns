namespace ExemploFacade.Classes
{
    public class VendaItem
    {
        public Venda Venda { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Desconto { get; set; }

        public VendaItem(int idProduto, int quantidade, decimal desconto)
        {
            IdProduto = idProduto;
            Quantidade = quantidade;
            Desconto = desconto;
        }
    }
}
