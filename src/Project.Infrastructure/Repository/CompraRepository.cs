namespace Project.Infrastructure.Repository
{
    using System.Collections.Generic;
    using Project.Infrastructure.Context;
    using Project.Infrastructure.Entity;
    using Project.Infrastructure.Interface;

    public class CompraRepository : ICompraRepository
    {
        private LojaContext _context;
        
        public CompraRepository(LojaContext context) => _context = context;

        public void Delete(Compra entity)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Compra entity)
        {
            using (var ctx = _context)
            {
                ctx.Compras.Add(entity);
                ctx.SaveChanges();
            }
        }

        public IList<Compra> SelectAll()
        {
            throw new System.NotImplementedException();
        }

        public Compra SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Compra entity)
        {
            throw new System.NotImplementedException();
        }
    }
}