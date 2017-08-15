namespace Project.Infrastructure.Entity
{
    using System;
    using System.Collections.Generic;
    using Entity.Base;

    public class Promocao : IEntity
    {
        public int Id { get; set; } 
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

        IList<Produto> Produtos {get;set;}
    }
}