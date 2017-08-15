namespace Project.Infrastructure.Interface.Base
{
    public interface IRepositoryUpdate<T> : IRepository<T>
    {
         void Update(T entity);
    }
}