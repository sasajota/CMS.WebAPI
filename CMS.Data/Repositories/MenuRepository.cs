using CMS.Data.Interfaces;
using CMS.Domain;
using System;

namespace CMS.Data.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly CMSContext _cmsContext;

        public MenuRepository(CMSContext cmsContext)
        {
            _cmsContext = cmsContext;
        }

        public Menu Create(Menu menu)
        {
            _cmsContext.Menus.Add(menu);
            _cmsContext.SaveChanges();
            return menu;
        }

        public Menu Delete(Menu menu)
        {
            menu.Status = Status.INACTIVE;
            _cmsContext.SaveChanges();
            return menu;
        }

        public Menu Edit(Menu menu)
        {
            _cmsContext.Menus.Update(menu);
            _cmsContext.SaveChanges();
            return menu;
        }

        public Menu List(Menu menu)
        {
            throw new NotImplementedException();
        }

        public Menu Read(int menuId)
        {
            return _cmsContext.Menus.Find(menuId);
        }
    }
}
