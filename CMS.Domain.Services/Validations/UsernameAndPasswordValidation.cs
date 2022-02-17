using System;
using System.Text.RegularExpressions;

namespace CMS.Domain.Services.Validations
{
    // TODO: Add interface
    public class UsernameAndPasswordValidation : IUsernameAndPasswordValidation
    {
        public bool ValidatePassword(string password)
        {
            var input = password;

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
                throw new Exception("Password should contain at least one lower case letter");
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                throw new Exception("Password should contain at least one upper case letter");
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                throw new Exception("Password should not be less than 8 or greater than 15 characters");
            }
            else if (!hasNumber.IsMatch(input))
            {
                throw new Exception("Password should contain at least one numeric value");
            }
            else if (!hasSymbols.IsMatch(input))
            {
                throw new Exception("Password should contain at least one special case characters");
            }
            else
            {
                return true;
            }
        }
        public bool ValidateUsername(string username)
        {
            var input = username;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Username can not be empty");
            }

            var isValid = new Regex(@"^[A-z][A-z|\.|\s]+$");

            if (!isValid.IsMatch(input))
            {
                throw new Exception("Username is not valid");
            }

            else
            {
                return true;
            }

        }
    }
}
