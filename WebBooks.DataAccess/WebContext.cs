using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebBooks.DataAccess
{
    public class WebContext:DbContext
    {
        public WebContext():base("BooksConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Authors> Autores { get; set; }
        public virtual DbSet<Books> Libros { get; set; }
        public virtual DbSet<BookAuthor> AutorLibro { get; set; }
    }
}
