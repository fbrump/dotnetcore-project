namespace Project.Infrastructure.Interface
{
    public interface IRepositoryInsert<T>
    {
         void Insert(T entity);
    }
}