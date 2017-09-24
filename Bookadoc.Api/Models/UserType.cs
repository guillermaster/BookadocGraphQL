using Bookadoc.Core.Models;
using GraphQL.Types;

namespace Bookadoc.Api.Models
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(x => x.Id).Description("Internal unique ID for each user");
            Field(x => x.Name).Description("User's first name");
            Field(x => x.LastName).Description("User's last name");
            Field(x => x.Email).Description("User's email (used as username)");
        }
    }
}
