namespace Project.Tests.Infrastructure.Repository
{
    using System;
    using Project.Infrastructure.Entity;
    using Project.Infrastructure.Factory;
    using Project.Infrastructure.Interface;
    using Xunit;

    public class CompraRepositoryTest: BaseTest, IDisposable
    {
        private ICompraRepository _repository;
        
        public CompraRepositoryTest() 
            : base()
            =>  _repository = RepositoryFactory.GetIntanciaOf<ICompraRepository>();

        public void Dispose() => _repository = null;
        

        [Fact]
        public void Should_insert_bread_product_with_purchase()
        {
            //Given
            var produto = new Produto();

            produto.Nome = "Pão Francês";
            produto.PrecoUnitario = 0.40;
            produto.Unidade = "Unidade";
            produto.Categoria = "Padaria";

            var compra = new Compra();

            compra.Quantidade = 6;
            compra.Produto = produto;
            compra.Preco = produto.PrecoUnitario * compra.Quantidade;

            //When
            _repository.Insert(compra);
            
            //Then
            Assert.NotNull(produto.Id);
            Assert.NotNull(compra.Id);

        }

    }
}