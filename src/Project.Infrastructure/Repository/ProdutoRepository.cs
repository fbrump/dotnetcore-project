namespace Project.Infrastructure.Repository
{
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using Context;
    using Interface;
    using Entity;
    using Repository.Base;

    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(LojaContext context) :base(context) { }

        // public void Delete(Produto entity)
        // {
        //     using (var ctx = _context)
        //     {
        //         ctx.Produtos.Remove(entity);
        //         ctx.SaveChanges();
        //     }
        // }

        // public void Insert(Produto entity)
        // {
        //     using (var ctx = _context)
        //     {
        //         ctx.Produtos.Add(entity);
        //         ctx.SaveChanges();
        //     }
        // }

        // public IList<Produto> SelectAll()
        // {
        //     IList<Produto> list = new List<Produto>();

        //     using (var ctx = _context)
        //     {
        //         list = ctx.Produtos.ToList();
        //     }

        //     return list;
        // }

        // public Produto SelectById(int id)
        // {
        //     var produto = new Produto();

        //     using (var ctx = _context)
        //     {
        //         produto = ctx.Produtos.FirstOrDefault(t => t.Id == id);
        //     }

        //     return produto;
        // }

        // public void Update(Produto entity)
        // {
        //     using (var ctx = _context)
        //     {
        //         ctx.Produtos.Update(entity);
        //         ctx.SaveChanges();
        //     }

        // }
    }
}