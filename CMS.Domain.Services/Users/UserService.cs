using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;

namespace CMS.Domain.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        PasswordValidation passwordValidation = new PasswordValidation();
        UsernameValidation usernameValidation = new UsernameValidation();

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(User user)
        {

            bool isPasswordValid = passwordValidation.ValidatePassword(user.Password);
            bool isUsernameValid = usernameValidation.ValidateUsername(user.Username);

            if(isPasswordValid == true && isUsernameValid == true)
            {
                return _userRepository.Create(user);
            }

            return null;
        }

        public User Delete(User user)
        {
            return _userRepository.Edit(user);
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
        
    }
}
