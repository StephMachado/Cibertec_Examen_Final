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

        public virtual DbSet<Autores> Autores { get; set; }
        public virtual DbSet<Libros> Libros { get; set; }
        public virtual DbSet<AutorLibro> AutorLibro { get; set; }
    }
}
