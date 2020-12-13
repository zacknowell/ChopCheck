using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using ChopCheck.Data.EntityFramework;
using ChopCheck.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ChopCheck.Data.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly ChopCheckContext context;

        private readonly DbSet<TEntity> dbSet;

        public ServiceBase(ChopCheckContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await Task.Run(() => this.dbSet.AddAsync(entity));
        }

        public async Task AddAsync(IEnumerable<TEntity> entity)
        {
            await this.dbSet.AddRangeAsync(entity);
        }

        public async Task<TEntity> FindAsync(int id)
        {
            return await this.dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(TEntity Entity)
        {
            await Task.Run(() => this.context.Update(Entity));
        }

        public async Task RemoveAsync(TEntity entity)
        {
            await Task.Run(() => this.dbSet.Remove(entity));
        }
        public async Task RemoveAsync(int id)
        {
            await Task.Run(() =>
            {
                var entity = this.FindAsync(id).Result;
                this.dbSet.Remove(entity);
            });
        }
    }
}
