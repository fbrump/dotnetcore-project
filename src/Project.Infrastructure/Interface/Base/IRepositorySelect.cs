namespace Project.Infrastructure.Interface.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IRepositorySelect<T> : IRepository<T>
    {
         IList<T> SelectAll ();

         T SelectById(int id);

         IList<T> SelectBy(Expression<Func<T, bool>> predicate);

    }
}