using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Contracts.Infrastructure;
using TestCleanArchitecture.Domain.Entities.Base;
using TestCleanArchitecture.Infrastructure.Persistence;

namespace TestCleanArchitecture.Infrastructure
{
    internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly AppDbContext _dbContext;
        //private readonly string _name;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            //_name = name;
        }

        public DbSet<TEntity> Table => _dbContext.Set<TEntity>();

        public IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public List<TEntity> GetAllList()
        {
            return GetAll().ToList();
        }

        public async Task<List<TEntity>> GetAllListAsync()
        {
            return await GetAll().ToListAsync();
        }

        public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().Where(predicate).ToList();
        }

        public async Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().Where(predicate).ToListAsync();
        }

        public virtual TEntity Get(int id)
        {
            var entity = FirstOrDefault(id);

            if (entity == null) { }

            return entity;
        }

        public virtual async Task<TEntity> GetAsync(int id)
        {
            var entity = await FirstOrDefaultAsync(id);

            if (entity == null) { }

            return entity;
        }

        public TEntity FirstOrDefault(int id)
        {
            return GetAll().FirstOrDefault(e => e.Id == id);
        }


        public Task<TEntity> FirstOrDefaultAsync(int id)
        {
            return Task.FromResult(FirstOrDefault(id));
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().FirstOrDefault(predicate);
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Task.FromResult(FirstOrDefault(predicate));
        }
    }
}
