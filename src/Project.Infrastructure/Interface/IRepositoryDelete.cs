namespace Project.Infrastructure.Interface
{
    public interface IRepositoryDelete<T>
    {
         void Delete(T entity);
    }
}