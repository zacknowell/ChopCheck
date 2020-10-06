using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ChopCheck.Data.Services
{
    public partial class ServiceBase<T> : IService<T>
    {
        private string _conn; 

        public T Insert(T Entity)
        {

            return Entity;
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<T> Get(IList<int> Id, IList<string> OrderBy = null)
        {
            List<T> EntityList = new List<T>();
            return EntityList;
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Update(int Id, T Entity)
        {
            throw new NotImplementedException();
        }

        public T Upsert(int Id, T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
