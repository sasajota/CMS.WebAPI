using CMS.Data.Interfaces;

namespace CMS.Domain.Services.Menus
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public Menu Create(Menu menu)
        {
            return _menuRepository.Create(menu);
        }

        public Menu Delete(Menu menu)
        {
            throw new System.NotImplementedException();
        }

        public Menu Edit(Menu menu)
        {
            throw new System.NotImplementedException();
        }

        public Menu List(Menu menu)
        {
            throw new System.NotImplementedException();
        }

        public Menu Read(int id)
        {
            return _menuRepository.Read(id);
        }
    }
}
