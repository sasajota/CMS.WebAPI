using CMS.Data.Interfaces;
using System;

namespace CMS.Domain.Services.Menus
{
    public class MenuService : IMenuService
    {
        private const string MissingEntityErrorMessage = "Menu does not exist.";
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
            if (menu.Status == Status.ACTIVE)
            {
                return _menuRepository.Delete(menu);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public Menu Edit(Menu menu)
        {
            if (menu.Status == Status.ACTIVE)
            {
                return _menuRepository.Edit(menu);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public Menu List(Menu menu)
        {
            throw new NotImplementedException();
        }

        public Menu Read(int id)
        {
            return _menuRepository.Read(id);
        }
    }
}
