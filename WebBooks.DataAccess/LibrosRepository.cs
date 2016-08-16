using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks.Model;

namespace WebBooks.DataAccess
{
    public class LibrosRepository : BaseDataAccess<Libros>
    {
        public Libros GetById(int id)
        {
            using (var dbContext = new WebContext())
            {
                return dbContext.Libros.FirstOrDefault(p => p.title_id == id);
            }
        }

        public int TotalCount()
        {
            using (var dbContext = new WebContext())
            {
                return dbContext.Libros.Count();
            }
        }

    }
}
