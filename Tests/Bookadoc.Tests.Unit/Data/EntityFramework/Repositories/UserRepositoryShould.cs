using Bookadoc.Core.Models;
using Bookadoc.Data.EntityFramework;
using Bookadoc.Data.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
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
            var dbLogger = new Mock<ILogger<BookadocContext>>();
            // https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory
            var options = new DbContextOptionsBuilder<BookadocContext>()
                .UseInMemoryDatabase(databaseName: "Bookadoc")
                .Options;

            using(var context = new BookadocContext(options, dbLogger.Object))
            {
                context.Users.Add(new User { Name = "Guillermo", LastName = "Pincay", Email = "guillermaster@gmail.com" });
                context.SaveChanges();
            }

            var bookadocContext = new BookadocContext(options, dbLogger.Object);
            var repoLogger = new Mock<ILogger<UserRepository>>();
            _userRepository = new UserRepository(bookadocContext, repoLogger.Object);
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
