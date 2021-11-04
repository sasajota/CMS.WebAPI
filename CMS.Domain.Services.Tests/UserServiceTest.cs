using CMS.Domain.Services.Users;
using System;
using Xunit;
using NSubstitute;
using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;

namespace CMS.Domain.Services.Tests
{
    public class UserServiceTest
    {
        private const string ValidPassword = "test";
        private readonly IUserRepository userRepository = Substitute.For<IUserRepository>();
        private readonly IUsernameAndPasswordValidation passwordValidation = Substitute.For<IUsernameAndPasswordValidation>();
        private readonly IUserService userService;
        public UserServiceTest()
        {
            userService = new UserService(userRepository, passwordValidation);
        }

        [Fact]
        public void Create_AllIsValid()
        {
            // Arrange
            User user = new User
            {
                Username = "test",
                Password = ValidPassword
            };
            passwordValidation.ValidatePassword(ValidPassword).Returns(true);
            userRepository.Create(user).Returns(user);

            // Act
            User actualUser = userService.Create(user);

            // Assert
            Assert.Same(user, actualUser);
            passwordValidation.Received().ValidatePassword(ValidPassword);
        }
    }
}
