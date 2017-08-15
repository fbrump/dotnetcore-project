namespace Project.Infrastructure.Interface.Base
{
    public interface ICRUDRepository<T> : IRepositoryInsert<T>, IRepositorySelect<T>, IRepositoryDelete<T>, IRepositoryUpdate<T>
    {
         
    }
}