namespace Project.Infrastructure.Factory
{
    using LightInject;
    using Interface;
    using Repository;
    using System;
    using Project.Infrastructure.Context;

    sealed public class RepositoryFactory
    {
        static ServiceContainer _container;

        static RepositoryFactory()
        {
            _container = new LightInject.ServiceContainer();
            
            // REGISTER ALL REPOSITORIES
            _container.Register<IProdutoRepository>(factory => new ProdutoRepository(new LojaContext()));

            //_container.RegisterInstance<IProdutoRepository>(new ProdutoRepository(new LojaContext()));

            //_container.Register<IProdutoRepository, ProdutoRepository>();

            //_container.RegisterConstructorDependency<IProdutoRepository>((factory, parameterInfo) => new LojaContext());
        }

        /// <summary>
        /// Method that get one instance for Repostiory based on yout interface.
        /// </summary>
        /// <returns></returns>
        public static T GetIntanciaOf<T>() => _container.GetInstance<T>();

    }
}