using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Books.Entitites;

namespace Books.Web.DataContexts
{
    public class BooksDb : DbContext
    {
        public BooksDb(): base("DefaultConnecti")
        {
            
        }
        public DbSet<Book> Books { get; set; }
    }
}