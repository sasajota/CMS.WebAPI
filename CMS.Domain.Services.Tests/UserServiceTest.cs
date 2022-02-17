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
        private const string ValidPassword = "test_password";
        private const string ValidUsername = "test_username";
        private const string InvalidPassword = "test_invalid_password";
        private readonly IUserRepository userRepository = Substitute.For<IUserRepository>();
        private readonly IUsernameAndPasswordValidation userValidator = Substitute.For<IUsernameAndPasswordValidation>();
        private readonly IEntityStatusValidator entityStatusValidator = Substitute.For<IEntityStatusValidator>();
        private readonly IUserService userService;
        public UserServiceTest()
        {
            userService = new UserService(userRepository, userValidator, entityStatusValidator);
        }

        [Fact]
        public void Create_AllIsValid()
        {
            // Arrange
            User user = new User
            {
                Username = ValidUsername,
                Password = ValidPassword,
            };
            userValidator.ValidatePassword(ValidPassword).Returns(true);
            userValidator.ValidateUsername(ValidUsername).Returns(true);
            userRepository.Create(user).Returns(user);

            // Act
            User actualUser = userService.Create(user);

            // Assert
            Assert.Same(user, actualUser);
            userValidator.Received().ValidatePassword(ValidPassword);
            userValidator.Received().ValidateUsername(ValidUsername);
        }

        [Fact]
        public void Create_PasswordIsNotValid()
        {
            // Arange
            User user = new User
            {
                Username = ValidUsername,
                Password = InvalidPassword,
            };
            userValidator.ValidateUsername(ValidUsername).Returns(true);
            userValidator.When(pv => pv.ValidatePassword(InvalidPassword)).Do(pv => throw new Exception());
            userRepository.Create(user).Returns(user);

            // Act
            // Assert
            Assert.Throws<Exception>(() => userService.Create(user));
            userRepository.DidNotReceiveWithAnyArgs().Create(default);
        }
    }
}
