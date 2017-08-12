namespace Project.Tests.Infrastructure.Repository
{
    using System;
    using Project.Infrastructure.Context;
    using Project.Infrastructure.Entity;
    using Xunit;

    public class ProdutoRepositoryTest
    {
        
        [Fact(Skip="Ignored - Access data base")]
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

    }
}