﻿using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;
using System;

namespace CMS.Domain.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUsernameAndPasswordValidation _passwordValidation, _usernameValidation;

        public UserService(IUserRepository userRepository,
            IUsernameAndPasswordValidation passwordValidation,
            IUsernameAndPasswordValidation usernameValidation)
        {
            _userRepository = userRepository;
            _passwordValidation = passwordValidation;
            _usernameValidation = usernameValidation;
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
            if (user.Status == Status.ACTIVE)
            {
                return _userRepository.Delete(user);
                user.Status = Status.INACTIVE;
            }
            throw new Exception("User does not exist.");
        }

        public User Edit(User user)
        {
            if (user.Status == Status.ACTIVE)
            {
                return _userRepository.Edit(user);
            }
            throw new Exception("User does not exist.");
        }

        public User List(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Read(int id)
        {
            return _userRepository.Read(id);
        }
        
    }
}
