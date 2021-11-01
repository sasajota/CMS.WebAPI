using CMS.Data.Interfaces;

namespace CMS.Domain.Services.MenuItems
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemService(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public MenuItem Create(MenuItem menuItem)
        {
            return _menuItemRepository.Create(menuItem);
        }

        public MenuItem Delete(MenuItem menuItem)
        {
            throw new System.NotImplementedException();
        }

        public MenuItem Edit(MenuItem menuItem)
        {
            throw new System.NotImplementedException();
        }

        public MenuItem List(MenuItem menuItem)
        {
            throw new System.NotImplementedException();
        }

        public MenuItem Read(int id)
        {
            return _menuItemRepository.Read(id);
        }
    }
}
