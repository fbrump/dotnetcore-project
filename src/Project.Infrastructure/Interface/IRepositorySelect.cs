namespace Project.Infrastructure.Interface
{
    using System.Collections.Generic;

    public interface IRepositorySelect<T> : IRepository<T>
    {
         IList<T> SelectAll ();

         T SelectById(int id);

    }
}