using EFCoreApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApplication.Data
{
    public class LibraryDbContext:DbContext 
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Person> Persons { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
