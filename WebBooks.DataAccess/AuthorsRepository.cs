using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks.Model;

namespace WebBooks.DataAccess
{
    public class AuthorsRepository : BaseDataAccess<Authors>
    {
        public Authors ObtenerAutor(int id)
        {
            using (var dbContext = new WebContext())
            {
                return dbContext.Autores.FirstOrDefault(p => p.au_id == id);
            }
        }
    }
}
