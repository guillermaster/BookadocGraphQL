using Bookadoc.Core.Models;
using System.Threading.Tasks;

namespace Bookadoc.Core.Data
{
    public interface IUserRepository
    {
        Task<User> Get(int id);

        Task<User> Get(string email);
    }
}
