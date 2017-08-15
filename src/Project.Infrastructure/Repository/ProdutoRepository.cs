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
        
    }
}