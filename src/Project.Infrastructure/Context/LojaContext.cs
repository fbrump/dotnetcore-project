namespace Project.Infrastructure.Context
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Entity;

    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=loja_db;Username=user_loja;Password=admin123");
        }

    }
}