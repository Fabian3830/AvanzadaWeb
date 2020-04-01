using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.REPOSITORY
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();

        Task<T> Get(string id);

        Task Create(T entity);

        Task<string> Update(string id, T entity);

        Task<DeleteResult> Remove(string id);

    }
}
