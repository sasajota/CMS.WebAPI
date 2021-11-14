using CMS.Data.Interfaces;
using CMS.Domain;
using CMS.Domain.Services.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<Menu> List()
        {
            return _menuRepository.List().Where(menu => menu.Status == Status.ACTIVE);
        }

        public Menu Read(int id)
        {
            return _menuRepository.Read(id);
        }
    }
}
