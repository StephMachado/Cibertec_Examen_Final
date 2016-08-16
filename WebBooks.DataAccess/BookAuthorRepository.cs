using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks.Model;

namespace WebBooks.DataAccess
{
    public class BookAuthorRepository : BaseDataAccess<BookAuthor>
    {
        public BookAuthor ObtenerAutorLibro(int title_id, int au_id)
        {
            using (var dbContext = new WebContext())
            {
                return dbContext.AutorLibro.FirstOrDefault(p => p.title_id == title_id &&
                                                                p.au_id == au_id);
            }
        }
    }
}
