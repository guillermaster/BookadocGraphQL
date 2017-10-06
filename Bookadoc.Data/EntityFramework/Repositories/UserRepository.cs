using Bookadoc.Core.Data;
using Bookadoc.Core.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Bookadoc.Data.EntityFramework.Repositories
{
    public class UserRepository : IUserRepository
    {
        private BookadocContext _db { get; set; }
        private readonly ILogger _logger;

        public UserRepository(BookadocContext db, ILogger<UserRepository> logger)
        {
            _db = db;
            _logger = logger;
        }

        public Task<User> Get(int id)
        {
            _logger.LogInformation("Get user with id = {id}", id);
            return _db.Users.FirstOrDefaultAsync(user => user.Id == id);
        }
    }
}
