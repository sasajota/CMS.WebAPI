using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Data.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);

        User Delete(User user);

        User Edit(User user);

        User Read(int userId);

        IEnumerable<User> List();
    }
}
