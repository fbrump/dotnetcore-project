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


    public class ProdutoRepositoryTest : IDisposable
    {
        private readonly IProdutoRepository _repository;
        private readonly LojaContext _context;

        public ProdutoRepositoryTest()
        {
            _context = new LojaContext();
            _repository = new ProdutoRepository(_context);
        }

        public void Dispose()
        {
            
        }

        [Fact]
        public void Should_insert_new_product()
        {
            var produto = new Produto();

            produto.Nome = "harry potter and the philosopher's stone";
            produto.Categoria = "Livros";
            produto.Preco = 19.89;

            _repository.Insert(produto);
            
            Assert.NotEqual(produto.Id, 0);
        }

        [Fact]
        public void Should_select_items()
        {
            //Given
            var list = new List<Produto>();

            //When
            using (var ctx = new LojaContext())
            {
                list = ctx.Produtos.ToList();
            }
        
            //Then
            Assert.True(list.Count() > 0);
        }

        [Fact(Skip="Acceces repository")]
        public void Should_update_product()
        {
            using (var ctx = new LojaContext())
            {
                var produto = ctx.Produtos.LastOrDefault();

                produto.Nome = "Harry Potter - Update";

                ctx.Produtos.Update(produto);
                ctx.SaveChanges();
            }

        }


    }
}