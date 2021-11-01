using CMS.Data.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace CMS.Domain.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(User user)
        {
            //bool isPasswordValid = ValidatePassword(user.Password, out string errorMessage);
            //bool isUsernameValid = ValidateUsername(user.Username, out string validateUserNameErrorMessage);

            // TODO: Validacija da je username unique
            // string must start with a letter, followed by a letter or a dot or a space

            // if(ValidatePassword(password, out string ErrorMessage) && ValidateUsername(username)) 
            // Ako je sve ok, kreiraj korisnika
            //if(isPasswordValid && isUsernameValid)
            //{
            //    return _userRepository.Create(user);
            //}
            return _userRepository.Create(user);
        }

        public User Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public User Edit(User user)
        {
            throw new System.NotImplementedException();
        }

        public User List(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Read(int id)
        {
            return _userRepository.Read(id);
        }
        private bool ValidateUsername(string username, out string ErrorMessage)
        {
            var input = username;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Username can not be empty");
            }

            var isValid = new Regex(@"^[A-z][A-z|\.|\s]+$");

            if (!isValid.IsMatch(input))
            {
                ErrorMessage = "Username is not valid";
                return false;
            }

            else
            {
                return true;
            }

        }

        /// <summary>
        /// // TODO: Validacija kompleksnosti passworda
        //at least one lower case letter,
        //at least one upper case letter,
        //at least special character,
        //at least one number,
        //at least 8 characters length
        /// </summary>
        /// <param name="password"></param>
        /// <param name="ErrorMessage"></param>
        /// <returns></returns>
        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password can not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                //TODO: Replace error messages with exceptions
                ErrorMessage = "Password should contain at least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than 8 or greater than 15 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
