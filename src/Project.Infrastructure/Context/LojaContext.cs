namespace Project.Infrastructure.Context
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Entity;
    
    public class LojaContext : DbContext
    {
        
        public Produto Produtos { get; set; }

    }
}