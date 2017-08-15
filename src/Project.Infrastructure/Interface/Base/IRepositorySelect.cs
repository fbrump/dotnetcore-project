namespace Project.Infrastructure.Interface.Base
{
    using System.Collections.Generic;

    public interface IRepositorySelect<T> : IRepository<T>
    {
         IList<T> SelectAll ();

         T SelectById(int id);

    }
}