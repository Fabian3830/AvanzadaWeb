using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DO.Interface
{
    public interface ICRUD<T>
    {
        Task<string> Insert(T entity);
        Task<string> Updated(string id, T entity);
        Task<string> Delete(string id);
        Task<IEnumerable<T>> GetAll();
        Task<string> GetOneById(string id);
    }
}
