using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChopCheck.Data.Dapper;
using ChopCheck.Data.DapperDAL;

namespace ChopCheck.Data.Services
{
    public partial class ServiceBase : IServiceBase
    {
        private readonly string tableName;

        private readonly IDapperDAL dapperDAL;

        private IDapperDAL dapperConsumer;

        public ServiceBase(string tableName)
        {
            this.tableName = tableName;
            this.dapperDAL = new DapperDAL.DapperDAL(this.tableName);
        }

        public ServiceBase(string tableName, IDapperDAL dapperDAL)
        {
            this.tableName = tableName;
            this.dapperDAL = dapperDAL;
        }

        public async Task<IDapperResponse> InsertAsync(IDapperModel Entity)
        {
            return await dapperDAL.SendAsync(Entity);
        }

        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IDapperResponse> GetAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IDapperResponse>> GetAsync(IList<int> Id, IList<string> OrderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IDapperResponse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDapperResponse> UpdateAsync(int Id, IDapperModel Entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDapperResponse> UpsertAsync(int Id, IDapperModel Entity)
        {
            throw new NotImplementedException();
        }
    }
}
