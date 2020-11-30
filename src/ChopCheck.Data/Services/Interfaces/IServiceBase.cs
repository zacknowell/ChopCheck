using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChopCheck.Data.Services
{
    public interface IServiceBase<TEntity>
    {
        Task AddAsync(TEntity entity);
        Task AddAsync(IEnumerable<TEntity> entity);
        Task<TEntity> FindAsync(int id);
        Task UpdateAsync(TEntity Entity);
        Task RemoveAsync(TEntity entity);
        Task RemoveAsync(int id);
    }
}
