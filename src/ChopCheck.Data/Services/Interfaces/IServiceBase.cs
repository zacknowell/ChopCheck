using ChopCheck.Data.Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChopCheck.Data.Services
{
    public interface IServiceBase
    {
        Task<IDapperResponse> InsertAsync(IDapperModel Entity);

        // Read
        Task<IDapperResponse> GetAsync(int Id);

        Task<IEnumerable<IDapperResponse>> GetAsync(IList<int> Id, IList<string> OrderBy = null);

        Task<IEnumerable<IDapperResponse>> GetAllAsync();

        // Update 
        Task<IDapperResponse> UpdateAsync(int Id, IDapperModel Entity);

        Task<IDapperResponse> UpsertAsync(int Id, IDapperModel Entity);

        //Delete
        Task DeleteAsync(int Id);
    }
}
