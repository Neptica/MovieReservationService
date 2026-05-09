using Microsoft.AspNetCore.Http;
using TestCleanArchitecture.Domain.Contracts.Infrastructure;
using TestCleanArchitecture.Domain.Entities.Base;
using TestCleanArchitecture.Infrastructure.Persistence;

namespace TestCleanArchitecture.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        //private readonly string _name;

        // TODO: Figure out how IHttpContextAccessor works
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IRepository<T> Repository<T>() where T : class, IEntity
        {
            return new Repository<T>(_appDbContext);
        }
    }
}
