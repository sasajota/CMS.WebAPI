using CMS.Data.Interfaces;

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
            // TODO: Validacija kompleksnosti passworda
            // TODO: Validacija da je username unique
            // Ako je sve ok, kreiraj korisnika
            return _userRepository.Create(user);
        }
    }
}
