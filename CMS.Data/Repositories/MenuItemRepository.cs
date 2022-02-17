using CMS.Data.Interfaces;
using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly CMSContext _cmsContext;

        public MenuItemRepository(CMSContext cmsContext)
        {
            _cmsContext = cmsContext;
        }

        public MenuItem Create(MenuItem menuItem)
        {
            _cmsContext.MenuItems.Add(menuItem);
            _cmsContext.SaveChanges();
            return menuItem;
        }

        public MenuItem Delete(MenuItem menuItem)
        {
            menuItem.Status = Status.INACTIVE;
            _cmsContext.SaveChanges();
            return menuItem;
        }

        public MenuItem Edit(MenuItem menuItem)
        {
            _cmsContext.MenuItems.Update(menuItem);
            _cmsContext.SaveChanges();
            return menuItem;
        }

        public IEnumerable<MenuItem> List()
        {
            return _cmsContext.MenuItems;
        }

        public MenuItem Read(int menuItemId)
        {
            return _cmsContext.MenuItems.Find(menuItemId);
        }
    }
}
