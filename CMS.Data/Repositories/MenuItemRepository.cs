using CMS.Data.Interfaces;
using CMS.Domain;

namespace CMS.Data.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly CMSContext _cmsContext;

        public MenuItemRepository(CMSContext cmsContext)
        {
            _cmsContext = cmsContext;
        }

        public MenuItem Create(MenuItem menuItems)
        {
            _cmsContext.MenuItems.Add(menuItems);
            _cmsContext.SaveChanges();
            return menuItems;
        }

        public MenuItem Delete(MenuItem menuItems)
        {
            _cmsContext.MenuItems.Remove(menuItems);
            _cmsContext.SaveChanges();
            return menuItems;
        }

        public MenuItem Edit(MenuItem menuItems)
        {
            _cmsContext.MenuItems.Update(menuItems);
            _cmsContext.SaveChanges();
            return menuItems;
        }

        public MenuItem List(MenuItem menuItems)
        {
            throw new System.NotImplementedException();
        }

        public MenuItem Read(MenuItem menuItems)
        {
            throw new System.NotImplementedException();
        }
    }
}
