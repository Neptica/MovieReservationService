using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Entities.Base;

namespace TestCleanArchitecture.Domain.Contracts.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();
        List<TEntity> GetAllList();
        Task<List<TEntity>> GetAllListAsync();
        List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);
        Task<TEntity> GetAsync(int id);
        TEntity FirstOrDefault(int id);
        Task<TEntity> FirstOrDefaultAsync(int id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
