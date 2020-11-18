using ChopCheck.Data.Dapper;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ChopCheck.Data.DapperDAL
{
    public interface IDapperDAL
    {
        Task<IEnumerable<T>> QueryAsync<T>(
               string sql,
               DynamicParameters param = null,
               IDbTransaction transaction = null,
               int? commandTimeout = null,
               CommandType? commandType = null);

        Task<int> ExecuteAsync(string sql, IEnumerable<string> parameters, IDbTransaction dbTransaction, int? timeout, CommandType? commandType);

        Task<IDapperResponse> SendAsync(IDapperModel request);

    }
}
