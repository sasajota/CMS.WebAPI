using CMS.Data.Interfaces;
using CMS.Domain;

namespace CMS.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CMSContext _cmsContext;

        public UserRepository(CMSContext cmsContext)
        {
            _cmsContext = cmsContext;
        }

        public User Create(User user)
        {
            _cmsContext.Users.Add(user);
            _cmsContext.SaveChanges();
            return user;
        }

        public User Delete(User user)
        {
            _cmsContext.Users.Remove(user);
            _cmsContext.SaveChanges();
            return user;
        }

        public User Edit(User user)
        {
            _cmsContext.Users.Update(user);
            _cmsContext.SaveChanges();
            return user;
        }

        public User List(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Read(int userId)
        {
            return _cmsContext.Users.Find(userId);
        }
    }
}
