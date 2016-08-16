using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks.Model;

namespace WebBooks.DataAccess
{
    public class BooksRepository : BaseDataAccess<Books>
    {
        public Books ObtenerLibro(int id)
        {
            using (var dbContext = new WebContext())
            {
                return dbContext.Libros.FirstOrDefault(p => p.title_id == id);
            }
        }

    }
}
