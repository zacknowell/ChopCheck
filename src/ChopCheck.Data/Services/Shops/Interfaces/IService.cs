using System;
using System.Collections.Generic;
using System.Text;

namespace ChopCheck.Data.Services
{
    public interface IService<T>
    {
        // Create
        T Insert(T Entity);

        // Read
        T Get(int Id);

        IList<T> Get(IList<int> Id, IList<string> OrderBy = null);

        IList<T> GetAll();

        // Update 
        T Update(int Id, T Entity);

        T Upsert(int Id, T Entity);

        //Delete
        void Delete(int Id);
    }
}
