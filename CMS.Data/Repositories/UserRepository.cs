using CMS.Data.Interfaces;
using CMS.Domain;
using System;
using System.Collections.Generic;

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

        public IEnumerable<User> List()
        {
            return _cmsContext.Users;
        }

        public User Read(int userId)
        {
            User user = _cmsContext.Users.Find(userId);
            return user;
        }
    }
}
