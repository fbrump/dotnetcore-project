namespace Project.Infrastructure.Interface
{
    using Entity;
    
    public interface ICompraRepository : IRepositoryInsert<Compra>, IRepositorySelect<Compra>, IRepositoryDelete<Compra>, IRepositoryUpdate<Compra>
    {
         
    }
}