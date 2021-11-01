using CMS.Domain;

namespace CMS.Data.Interfaces
{
    public interface IMenuItemRepository
    {
        MenuItem Create(MenuItem menuItem);

        MenuItem Delete(MenuItem menuItem);

        MenuItem Edit(MenuItem menuItem);

        MenuItem Read(int menuItemId);

        MenuItem List(MenuItem menuItem);
    }
}
