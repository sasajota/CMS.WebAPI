using System;
using System.Text.RegularExpressions;

namespace CMS.Domain.Services.Validations
{
    public class UsernameValidation
    {
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
