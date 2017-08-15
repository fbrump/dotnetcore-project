namespace Project.Infrastructure.Interface.Base
{
    public interface IRepositoryInsert<T> : IRepository<T>
    {
         void Insert(T entity);
    }
}