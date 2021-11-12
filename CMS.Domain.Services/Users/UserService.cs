using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;
using System;

namespace CMS.Domain.Services.Users
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IUsernameAndPasswordValidation _passwordValidation, _usernameValidation;
        private readonly IEntityStatusValidator _entityStatusValidator;

        public UserService(IUserRepository userRepository,
            IUsernameAndPasswordValidation passwordValidation,
            IUsernameAndPasswordValidation usernameValidation,
            IEntityStatusValidator entityStatusValidator)
        {
            _userRepository = userRepository;
            _passwordValidation = passwordValidation;
            _usernameValidation = usernameValidation;
            _entityStatusValidator = entityStatusValidator;
        }

        public User Create(User user)
        {

            bool isPasswordValid = _passwordValidation.ValidatePassword(user.Password);
            bool isUsernameValid = _usernameValidation.ValidateUsername(user.Username);

            if(isPasswordValid == true && isUsernameValid == true)
            {
                return _userRepository.Create(user);
            }

            return null;
        }

        public User Delete(User user)
        {
            _entityStatusValidator.Validate(user.status);
            return _userRepository.Delete(user);
        }

        public User Edit(User user)
        {
            _entityStatusValidator.Validate(user.status);
            return _userRepository.Edit(user);
        }

        public User List(User user)
        {
            return _userRepository.List(user);
        }

        public User Read(int id)
        {
            return _userRepository.Read(id);
        }
        
    }
}
