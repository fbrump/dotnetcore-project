namespace Project.Infrastructure.Repository
{
    using System.Collections.Generic;
    using Context;
    using Entity;
    using Interface;
    using Repository.Base;

    public class CompraRepository : BaseRepository<Compra>, ICompraRepository
    {
        public CompraRepository(LojaContext context) : base(context) { }
        
    }
}