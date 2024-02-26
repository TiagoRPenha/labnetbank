using LabNetBank.Business.Interfaces.Repositories;
using LabNetBank.Business.Models;
using LabNetBank.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetBank.Infrastructure.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        protected readonly LabNetBankContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        protected BaseRepository(LabNetBankContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            _dbSet.Add(entity);

            _dbContext.SaveChanges();

            return entity;
        }

        public async Task<int> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
