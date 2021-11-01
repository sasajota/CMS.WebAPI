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
        //DELETE NOTE:
        //This is not a mistake, delete should not actually delete objects, rather it should update it's status
        public User Delete(User user)
        {
            _cmsContext.Users.Update(user);
            _cmsContext.SaveChanges();
            return null;
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
