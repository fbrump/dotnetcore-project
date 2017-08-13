namespace Project.Infrastructure.Repository
{
    using System.Collections.Generic;
    using Context;
    using Interface;
    using Project.Infrastructure.Entity;

    public class ProdutoRepository : IProdutoRepository
    {
        private LojaContext _context;
        
        public ProdutoRepository(LojaContext context) => _context = context;

        public void Delete(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Produto entity)
        {
            using (var ctx = _context)
            {
                ctx.Produtos.Add(entity);
                ctx.SaveChanges();
            }
        }

        public IList<Produto> SelectAll()
        {
            throw new System.NotImplementedException();
        }

        public IList<Produto> SelectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Produto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}