namespace Project.Infrastructure.Interface.Base
{
    public interface IRepositoryDelete<T> : IRepository<T>
    {
         void Delete(T entity);
    }
}