namespace Project.Infrastructure.Entity
{
    public class Compra
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public decimal Preco { get; set; }
    }
}