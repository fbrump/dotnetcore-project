namespace Project.Tests.Infrastructure.Factory
{
    using Xunit;
    using System;
    using Project.Infrastructure.Factory;
    using Project.Infrastructure.Repository;
    using Project.Infrastructure.Interface;

    public class RepositoryFactoryTest : BaseTest, IDisposable
    {
        public RepositoryFactoryTest() : base()
        {

        }

        public void Dispose()
        {

        }

        [Fact]
        public void Should_instance_new_product_repository()
        {
            //Given
            
            //When
            var instancia = RepositoryFactory.GetIntanciaOf<IProdutoRepository>();

            //Then
            Assert.NotNull(instancia);
            Assert.IsType<ProdutoRepository>(instancia);
        }

    }
}