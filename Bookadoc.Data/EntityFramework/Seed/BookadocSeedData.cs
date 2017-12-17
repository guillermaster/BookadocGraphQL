using Bookadoc.Core;
using Bookadoc.Core.Models;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Bookadoc.Data.EntityFramework.Seed
{
    public static class BookadocSeedData
    {
        public static void EnsureSeedData(this BookadocContext db)
        {
            db._logger.LogInformation("Seeding database");

            if (!db.Users.Any())
            {
                db._logger.LogInformation("Seeding users");
                var defaultUser = new User
                {
                    Name = "Guillermo",
                    LastName = "Pincay",
                    Email = "guillermaster@gmail.com",
                    Password = "123456",
                    Active = true,
                    UserTypeId = Enums.UserType.Client
                };
                db.Users.Add(defaultUser);

                db.SaveChanges();

                var defaultUser2 = new User
                {
                    Name = "Sebastian",
                    LastName = "Pincay",
                    Email = "guillesebaspincay@gmail.com",
                    Password = "123456",
                    Active = true,
                    UserTypeId = Enums.UserType.Supplier
                };
                db.Users.Add(defaultUser2);

                db.SaveChanges();
            }
        }
    }
}
