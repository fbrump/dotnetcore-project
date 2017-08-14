namespace Project.Tests.Infrastructure.Repository
{
    using System;
    using Project.Infrastructure.Context;
    using Project.Infrastructure.Entity;
    using Project.Infrastructure.Interface;
    using Project.Infrastructure.Repository;
    using Xunit;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using Project.Infrastructure.Factory;

    public class ProdutoRepositoryTest : BaseTest, IDisposable
    {
        private IProdutoRepository _repository;
        
        public ProdutoRepositoryTest() : base()
        {
            _repository = RepositoryFactory.GetIntanciaOf<IProdutoRepository>();
        }

        public void Dispose()
        {
            _repository = null;
        }

        [Fact]
        public void Should_insert_new_product()
        {
            //Given
            var produto = new Produto();

            produto.Nome = "harry potter and the philosopher's stone";
            produto.Categoria = "Livros";
            produto.PrecoUnitario = 19.89;
            produto.Unidade = "Unidade";

            //When
            _repository.Insert(produto);
            
            //Then
            Assert.NotEqual(produto.Id, 0);
        }

        [Fact]
        public void Should_select_items()
        {
            //Given
            IList<Produto> list = new List<Produto>();

            //When
            list = _repository.SelectAll();
        
            //Then
            Assert.True(list.Count() > 0);
        }

        [Fact]
        public void Should_update_product()
        {
            //Given
            const string nome = "Harry Potter - Update";

            var produtoUpdate = _repository.SelectAll().LastOrDefault();

            produtoUpdate.Nome = nome;

            _repository = RepositoryFactory.GetIntanciaOf<IProdutoRepository>();
            //When
            _repository.Update(produtoUpdate);

            //Then
            Assert.Equal(produtoUpdate.Nome, nome);
        }

        [Fact(Skip="Accessing database")]
        public void Should_delete_product()
        {
            //Given
            var produto = _repository.SelectAll().FirstOrDefault();
            int id = produto.Id;
            
            _repository = RepositoryFactory.GetIntanciaOf<IProdutoRepository>();

            //When
            _repository.Delete(produto);

            _repository = RepositoryFactory.GetIntanciaOf<IProdutoRepository>();

            produto = _repository.SelectById(id);

            //Then
            Assert.Null(produto);
        }

        [Fact]
        public void Should_get_connection_string_from_json_appsettings()
        {
            //Given
            const string key = "ConnectionStrings:LojaDatabase";
            const string connection_string = "Host=localhost;Database=loja_db;Username=user_loja;Password=admin12";

            //When
            var result = base._configuration.Configuration[key];

            //Then
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(connection_string, result);
        }

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
            _repository.Insert(produto);

            var _repositoryPurchase = RepositoryFactory.GetIntanciaOf<ICompraRepository>();

            _repositoryPurchase.Insert(compra);
            
            //Then
            Assert.NotNull(produto.Id);
            Assert.NotNull(compra.Id);

        }
    }
}