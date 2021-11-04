using CMS.Data.Interfaces;
using System;

namespace CMS.Domain.Services.MenuItems
{
    public class MenuItemService : IMenuItemService
    {
        private const string MissingEntityErrorMessage = "Menu item does not exist.";
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
            if (menuItem.Status == Status.ACTIVE)
            {
                return _menuItemRepository.Delete(menuItem);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public MenuItem Edit(MenuItem menuItem)
        {
            if (menuItem.Status == Status.ACTIVE)
            {
                return _menuItemRepository.Edit(menuItem);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public MenuItem List(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public MenuItem Read(int id)
        {
            return _menuItemRepository.Read(id);
        }
    }
}
