namespace Project.Infrastructure.Interface
{
    public interface ICRUDRepository<T> : IRepositoryInsert<T>, IRepositorySelect<T>, IRepositoryDelete<T>, IRepositoryUpdate<T>
    {
         
    }
}