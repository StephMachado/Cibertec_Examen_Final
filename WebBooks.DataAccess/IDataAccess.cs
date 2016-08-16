using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBooks.DataAccess
{
    public interface IDataAccess<T>
    {
        List<T> GetList();
        int Add(T Entity);
        int Delete(T Entity);
        int Update(T Entity);
        int Count();
    }
}
