using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Data.Interfaces
{
    public interface IMenuRepository
    {
        Menu Create(Menu menu);

        Menu Delete(Menu menu);

        Menu Edit(Menu menu);

        Menu Read(int menuId);

        IEnumerable<Menu> List();
    }
}
