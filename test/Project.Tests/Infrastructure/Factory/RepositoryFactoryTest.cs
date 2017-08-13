namespace Project.Tests.Infrastructure.Factory
{
    using Xunit;
    using System;
    using Project.Infrastructure.Factory;

    public class RepositoryFactoryTest : IDisposable
    {
        RepositoryFactory _factory;

        public RepositoryFactoryTest()
        {
            _factory = new RepositoryFactory();
        }

        public void Dispose()
        {
            _factory = null;
        }

    }
}