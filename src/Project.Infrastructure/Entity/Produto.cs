namespace Project.Infrastructure.Entity
{
    using Entity.Base;
    public class Produto : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double PrecoUnitario { get; set; }
        public string Unidade { get; set; }        
    }
}