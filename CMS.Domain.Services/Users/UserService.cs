using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Domain.Services.Users
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IUsernameAndPasswordValidation _userValidator;
        private readonly IEntityStatusValidator _entityStatusValidator;

        public UserService(IUserRepository userRepository,
            IUsernameAndPasswordValidation userValidator,
            IEntityStatusValidator entityStatusValidator)
        {
            _userRepository = userRepository;
            _userValidator = userValidator;
            _entityStatusValidator = entityStatusValidator;
        }

        public User Create(User user)
        {

            bool isPasswordValid = _userValidator.ValidatePassword(user.Password);
            bool isUsernameValid = _userValidator.ValidateUsername(user.Username);

            if(isPasswordValid == true && isUsernameValid == true)
            {
                return _userRepository.Create(user);
            }

            return null;
        }

        public User Delete(User user)
        {
            _entityStatusValidator.Validate(user.Status);
            return _userRepository.Delete(user);
        }

        public User Edit(User user)
        {
            _entityStatusValidator.Validate(user.Status);
            return _userRepository.Edit(user);
        }

        public IEnumerable<User> List()
        {
            return _userRepository.List().Where(user => user.Status == Status.ACTIVE);
        }

        public User Read(int id)
        {
            return _userRepository.Read(id);
        }
        
    }
}
