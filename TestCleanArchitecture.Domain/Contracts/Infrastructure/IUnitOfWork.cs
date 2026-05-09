using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Entities.Base;

namespace TestCleanArchitecture.Domain.Contracts.Infrastructure
{
    public interface IUnitOfWork
    {
        //void SaveChanges();
        //IDbContextTransaction BeginTransaction;
        //void Commit(IDbContextTransaction transaction);
        //void Commit(IDbContextTransaction transaction);
        //Task SaveChangesAsync();

        IRepository<T> Repository<T>() where T : class, IEntity;
    }
}
