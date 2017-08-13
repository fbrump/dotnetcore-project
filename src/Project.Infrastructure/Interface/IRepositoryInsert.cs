namespace Project.Infrastructure.Interface
{
    public interface IRepositoryInsert<T> : IRepository<T>
    {
         void Insert(T entity);
    }
}