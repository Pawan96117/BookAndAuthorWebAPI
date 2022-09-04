using BookAndAuthorWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BookAndAuthorWebAPI.DbConnection
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
