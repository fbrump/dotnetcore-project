namespace Project.Tests.Infrastructure.Repository
{
    using System;
    using Project.Infrastructure.Context;
    using Project.Infrastructure.Entity;
    using Xunit;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;


    public class ProdutoRepositoryTest : IDisposable
    {
        public ProdutoRepositoryTest()
        {
            Console.WriteLine("========= ==================");
            Console.WriteLine("========= TestFixtureSetUp");
            Console.WriteLine("========= ==================");
        }

        public void Dispose()
        {
            Console.WriteLine("========= ==================");
            Console.WriteLine("========= TestFixtureTearDown");
            Console.WriteLine("========= ==================");
        }

        [Fact]
        public void Should_insert_new_product()
        {
            var produto = new Produto();

            produto.Nome = "Harry Potter";
            produto.Categoria = "Lrivros";
            produto.Preco = 19.89;

            using (var ctx = new LojaContext())
            {
                ctx.Produtos.Add(produto);
                ctx.SaveChanges();
            }

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

        [Fact]
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