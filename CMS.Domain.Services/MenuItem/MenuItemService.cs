using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Domain.Services.MenuItems
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IEntityStatusValidator _entityStatusValidator;

        public MenuItemService(IMenuItemRepository menuItemRepository,
            IEntityStatusValidator entityStatusValidator)
        {
            _menuItemRepository = menuItemRepository;
            _entityStatusValidator = entityStatusValidator;
        }

        public MenuItem Create(MenuItem menuItem)
        {
            return _menuItemRepository.Create(menuItem);
        }

        public MenuItem Delete(MenuItem menuItem)
        {
            _entityStatusValidator.Validate(menuItem.Status);
            return _menuItemRepository.Delete(menuItem);
        }

        public MenuItem Edit(MenuItem menuItem)
        {
            _entityStatusValidator.Validate(menuItem.Status);
            return _menuItemRepository.Edit(menuItem);
        }

        public IEnumerable<MenuItem> List()
        {
            return _menuItemRepository.List().Where(menuItem => menuItem.Status == Status.ACTIVE);
        }

        public MenuItem Read(int id)
        {
            return _menuItemRepository.Read(id);
        }
    }
}
