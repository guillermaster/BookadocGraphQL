using Bookadoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bookadoc.Core.Data
{
    public interface IUserRepository
    {
        Task<User> Get(int id);
    }
}
