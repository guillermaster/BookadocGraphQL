using Bookadoc.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Bookadoc.Core.Models;
using System.Threading.Tasks;

namespace Bookadoc.Data.InMemory
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Guillermo",
                LastName = "Pincay",
                Email = "guillermaster@gmail.com"
            },
            new User
            {
                Id = 2,
                Name = "Guillermo Sebastian",
                LastName = "Pincay",
                Email = "guillesebaspincay@gmail.com"
            }
        };

        public Task<User> Get(int id)
        {
            return Task.FromResult(_users.FirstOrDefault(user => user.Id == id));
        }

        public Task<User> Get(string email)
        {
            return Task.FromResult(_users.FirstOrDefault(user => user.Email == email));
        }
    }
}
