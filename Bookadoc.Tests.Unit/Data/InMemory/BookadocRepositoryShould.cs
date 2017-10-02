using Bookadoc.Data.InMemory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bookadoc.Tests.Unit.Data.InMemory
{
    public class BookadocRepositoryShould
    {
        private readonly UserRepository _userRepository;

        public BookadocRepositoryShould()
        {
            _userRepository = new UserRepository();
        }

        [Fact]
        public async void ReturnGuillermoGivenIdOf1()
        {
            //When
            var user = await _userRepository.Get(1);

            //Then
            Assert.NotNull(user);
            Assert.Equal("Guillermo", user.Name);
        }
    }
}
