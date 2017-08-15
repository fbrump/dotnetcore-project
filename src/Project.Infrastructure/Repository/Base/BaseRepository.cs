namespace Project.Infrastructure.Repository.Base
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;
    using System.Linq.Expressions;
    using Context;
    using Interface.Base;
    using Entity.Base;

    public class BaseRepository<T> : ICRUDRepository<T>  
        where T : class, IEntity
    {
        protected LojaContext _context;

        public BaseRepository(LojaContext context)
            => _context = context;

        public void Delete(T entity)
        {
            using (var ctx = _context)
            {
                ctx.Set<T>().Remove(entity);
                ctx.SaveChanges();
            }
        }

        public void Insert(T entity)
        {
            using (var ctx = _context)
            {
                ctx.Set<T>().Add(entity);
                ctx.SaveChanges();
            }
        }

        public IList<T> SelectAll()
        {
            List<T> list = new List<T>();

            using (var ctx = _context)
            {
                list = _context.Set<T>()
                    .ToList();
            }

            return list;
        }

        public IList<T> SelectBy(Expression<Func<T, bool>> predicate)
        {
            List<T> list = new List<T>();

            using (var ctx = _context)
            {
                list = _context.Set<T>()
                    .Where(predicate)
                    .ToList();
            }

            return list;
        }

        public T SelectById(int id)
        {
            T entity;

            using (var ctx = _context)
            {
                entity = _context.Set<T>()
                    .Find(id);
            }

            return entity;
        }

        public void Update(T entity)
        {
            using (var ctx = _context)
            {
                //ctx.Entry(entity).State = System.Data.EntityState.Modified;
                ctx.Update<T>(entity);
                ctx.SaveChanges();
            }
        }
    }
}