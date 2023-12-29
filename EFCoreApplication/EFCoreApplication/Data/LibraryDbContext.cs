using EFCoreApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApplication.Data
{
  
    public class LibraryDbContext:DbContext 
    {

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Person> Persons { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
