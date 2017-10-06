using Bookadoc.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Bookadoc.Data.EntityFramework
{
    public class BookadocContext : DbContext
    {
        public readonly ILogger _logger;

        public BookadocContext(DbContextOptions options, ILogger<BookadocContext> logger)
            : base(options)
        {
            _logger = logger;
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}
