namespace Project.Tests.Infrastructure.Repository
{
    using System;
    using Project.Infrastructure.Entity;
    using Project.Infrastructure.Factory;
    using Project.Infrastructure.Interface;
    using Xunit;

    public class PromocaoRepositoryTest: BaseTest, IDisposable
    {
        private IProdutoRepository _repository;
        
        public PromocaoRepositoryTest() : base()
        {
            _repository = RepositoryFactory.GetIntanciaOf<IProdutoRepository>();
        }

        public void Dispose()
        {
            _repository = null;
        }

        [Fact]
        public void Should_insert_new_promotion()
        {
            //Given
            var promocaoPascoa = new Promocao();
            
            promocaoPascoa.Descricao = "Páscoa Felix";
            promocaoPascoa.DataInicio = DateTime.Now;

            //When
            
            //Then
        }
    }
}