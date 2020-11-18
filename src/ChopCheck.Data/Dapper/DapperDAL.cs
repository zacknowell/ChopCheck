using System.Configuration;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ChopCheck.Data.Dapper;
using Patterns.Dapper;
using System;
using Patterns.Dapper.Extensions;

namespace ChopCheck.Data.DapperDAL
{
    public class DapperDAL : IDapperDAL
    {
        private readonly string connectionString;

        private readonly string tableName;

        private SqlConnection sqlConnection;

        public DapperDAL(string tableName)
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["ChopCheckApplication"].ConnectionString;
            this.sqlConnection = new SqlConnection(this.connectionString);
            this.tableName = tableName;
        }
        public DapperDAL(string connectionString, string tableName)
        {
            this.connectionString = connectionString;
            this.sqlConnection = new SqlConnection(this.connectionString);
            this.tableName = tableName;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(
            string sql,
            DynamicParameters param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return await sqlConnection.QueryAsync<T>(sql, param, transaction, commandTimeout, commandType);
        }

        public async Task<int> ExecuteAsync(string sql, IEnumerable<string> parameters, IDbTransaction dbTransaction, int? timeout, CommandType? commandType)
        {
            return await sqlConnection.ExecuteAsync(sql, parameters, dbTransaction, timeout, commandType);
        }

        public async Task<IDapperResponse> SendAsync(IDapperModel request)
        {
            var response = new DapperResponse();

            try
            {
                string sql = string.Empty;
                
                await sqlConnection
                    .ExecuteAsync(
                        sql,
                        request.GetDynamicParameters(),
                        commandType: CommandType.StoredProcedure)
                    .ConfigureAwait(false);

                response.Success = true;
            }
            catch (Exception e)
            {
                response.Success = false;
            }

            return response;
        }
    }
}
