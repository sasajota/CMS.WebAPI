using CMS.Data.Interfaces;
using CMS.Domain;
using CMS.Domain.Services.Validations;
using System;

namespace CMS.Domain.Services.Menus
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IEntityStatusValidator _entityStatusValidator;

        public MenuService(IMenuRepository menuRepository,
            IEntityStatusValidator entityStatusValidator)
        {
            _menuRepository = menuRepository;
            _entityStatusValidator = entityStatusValidator;
        }

        public Menu Create(Menu menu)
        {
            return _menuRepository.Create(menu);
        }

        public Menu Delete(Menu menu)
        {
            _entityStatusValidator.Validate(menu.Status);
            return _menuRepository.Delete(menu);
        }

        public Menu Edit(Menu menu)
        {
            _entityStatusValidator.Validate(menu.Status);
            return _menuRepository.Edit(menu);
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
