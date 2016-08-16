using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebBooks.DataAccess
{
    public class BaseDataAccess<T> : IDataAccess<T> where T : class
    {
        public int Add(T Entity)
        {
            using (var dbContext = new WebContext())
            {
                dbContext.Entry(Entity).State = EntityState.Added;
                return dbContext.SaveChanges();
            }
        }

        public int Count()
        {
            using (var dbContext = new WebContext())
            {
                return dbContext.Set<T>().Count();
            }
        }

        public int Delete(T Entity)
        {
            using (var dbContext = new WebContext())
            {
                dbContext.Entry(Entity).State = EntityState.Deleted;
                return dbContext.SaveChanges();
            }
        }

        public List<T> GetList()
        {
            using (var dbContext = new WebContext())
            {
                return dbContext.Set<T>().ToList();
            }
        }

        public int Update(T Entity)
        {
            using (var dbContext = new WebContext())
            {
                dbContext.Entry(Entity).State = EntityState.Modified;
                return dbContext.SaveChanges();
            }
        }
    }
}
