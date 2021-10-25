using CMS.Domain;

namespace CMS.Data.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);
    }
}
