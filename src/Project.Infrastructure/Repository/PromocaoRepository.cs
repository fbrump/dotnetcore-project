namespace Project.Infrastructure.Repository
{
    using Project.Infrastructure.Context;
    using Project.Infrastructure.Entity;
    using Project.Infrastructure.Interface;
    using Project.Infrastructure.Repository.Base;

    public class PromocaoRepository : BaseRepository<Promocao>, IPromocaoRepository
    {
        public PromocaoRepository(LojaContext context) : base(context) { }
        
    }
}