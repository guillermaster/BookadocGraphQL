using Bookadoc.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookadoc.Data.EntityFramework
{
    public class BookadocContext : DbContext
    {
        public BookadocContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}
