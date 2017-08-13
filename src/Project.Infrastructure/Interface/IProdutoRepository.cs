namespace Project.Infrastructure.Interface
{
    using Project.Infrastructure.Entity;

    public interface IProdutoRepository : IRepositoryInsert<Produto>, IRepositorySelect<Produto>, IRepositoryDelete<Produto>, IRepositoryUpdate<Produto>
    {
         
    }
}