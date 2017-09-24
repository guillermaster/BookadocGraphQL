using Bookadoc.Core.Data;
using GraphQL.Types;

namespace Bookadoc.Api.Models
{
    public class UserQuery : ObjectGraphType
    {
        private IUserRepository _userRepository { get; set; }

        public UserQuery(IUserRepository _userRepository)
        {
            Field<UserType>(
                "first",
                resolve: context => _userRepository.Get(1)
            );
        }
    }
}
