namespace Project.Infrastructure.Interface
{
    using System.Collections.Generic;

    public interface IRepositorySelect<T>
    {
         IList<T> SelectAll ();

         IList<T> SelectById(int id);

    }
}