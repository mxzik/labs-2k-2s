using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Operations
{
    public interface IRepository<T>
    {
        bool Delete(T item);
        bool Create(T item);
        bool Update(T item);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByQuery(Func<T, bool> predicate);
    }
}
