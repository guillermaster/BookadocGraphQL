using Bookadoc.Core.Models;
using Bookadoc.Data.EntityFramework;
using Bookadoc.Data.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bookadoc.Tests.Unit.Data.EntityFramework.Repositories
{
    public class UserRepositoryShould
    {
        private readonly UserRepository _userRepository;

        public UserRepositoryShould()
        {
            //Given
            // https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory
            var options = new DbContextOptionsBuilder<BookadocContext>()
                .UseInMemoryDatabase(databaseName: "Bookadoc")
                .Options;

            using(var context = new BookadocContext(options))
            {
                context.Users.Add(new User { Name = "Guillermo", LastName = "Pincay", Email = "guillermaster@gmail.com" });
                context.SaveChanges();
            }

            var bookadocContext = new BookadocContext(options);
            _userRepository = new UserRepository(bookadocContext);
        }

        [Fact]
        public async void ReturnGuillermoGivenIdOf1()
        {
            // When
            var user = await _userRepository.Get(1);

            // Then
            Assert.NotNull(user);
            Assert.Equal("Guillermo", user.Name);
        }
    }
}
