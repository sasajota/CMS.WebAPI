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
            // TODO: Validacija kompleksnosti passworda
            // TODO: Validacija da je username unique
            // Ako je sve ok, kreiraj korisnika
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

        public MenuItem Read(MenuItem menuItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
