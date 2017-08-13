namespace Project.Infrastructure.Interface
{
    public interface IRepositoryUpdate<T> : IRepository<T>
    {
         void Update(T entity);
    }
}