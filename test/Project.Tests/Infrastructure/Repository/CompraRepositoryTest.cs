namespace Project.Tests.Infrastructure.Repository
{
    using System;
    using Project.Infrastructure.Factory;
    using Project.Infrastructure.Interface;
    
    public class CompraRepositoryTest: BaseTest, IDisposable
    {
        private ICompraRepository _repository;
        
        public CompraRepositoryTest() 
            : base()
            =>  _repository = RepositoryFactory.GetIntanciaOf<ICompraRepository>();

        public void Dispose() => _repository = null;
        
        
    }
}