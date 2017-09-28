using Bookadoc.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Bookadoc.Api
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BookadocContext>
    {
        public BookadocContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BookadocContext>();
            var connectionString = configuration.GetConnectionString("BookadocDatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new BookadocContext(builder.Options);
        }
    }
}
