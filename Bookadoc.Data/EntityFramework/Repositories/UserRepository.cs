using Bookadoc.Core.Data;
using Bookadoc.Core.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bookadoc.Data.EntityFramework.Repositories
{
    public class UserRepository : IUserRepository
    {
        private BookadocContext _db { get; set; }

        public UserRepository(BookadocContext db)
        {
            _db = db;
        }

        public Task<User> Get(int id)
        {
            return _db.Users.FirstOrDefaultAsync(user => user.Id == id);
        }
    }
}
