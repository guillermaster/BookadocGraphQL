using Bookadoc.Core.Models;
using System.Linq;

namespace Bookadoc.Data.EntityFramework.Seed
{
    public static class BookadocSeedData
    {
        public static void EnsureSeedData(this BookadocContext db)
        {
            if (!db.Users.Any())
            {
                var defaultUser = new User
                {
                    Id = 1,
                    Name = "Guillermo",
                    LastName = "Pincay",
                    Email = "guillermaster@gmail.com",
                    Password = "123456",
                    Active = true
                };
                db.Users.Add(defaultUser);
                db.SaveChanges();
            }
        }
    }
}
