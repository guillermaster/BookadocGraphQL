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
                "user",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = QueryArgs.User.Email, Description = "User email address" }
              ),
                resolve: context => {
                    var email = context.GetArgument<string>(QueryArgs.User.Email);
                    return _userRepository.Get(email);
                } 
            );
        }
    }
}
