namespace Project.Infrastructure.Factory
{
    using LightInject;
    using Interface;
    using Repository;

    public class RepositoryFactory
    {
        ServiceContainer _container;

        public RepositoryFactory()
        {
            _container = new LightInject.ServiceContainer();

            _container.Register(IProdutoRepository, ProdutoRepository);
        }


    }
}