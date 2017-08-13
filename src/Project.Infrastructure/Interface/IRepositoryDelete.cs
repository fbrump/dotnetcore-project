namespace Project.Infrastructure.Interface
{
    public interface IRepositoryDelete<T> : IRepository<T>
    {
         void Delete(T entity);
    }
}