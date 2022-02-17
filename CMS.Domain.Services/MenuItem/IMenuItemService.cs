using System.Collections.Generic;

namespace CMS.Domain.Services.MenuItems
{
    public interface IMenuItemService
    {
        MenuItem Create(MenuItem menuItem);

        MenuItem Delete(MenuItem menuItem);

        MenuItem Edit(MenuItem menuItem);

        MenuItem Read(int id);

        IEnumerable<MenuItem> List();

    }
}
