using CMS.Domain;

namespace CMS.Data.Interfaces
{
    public interface IMenuItemRepository
    {
        MenuItem Create(MenuItem menuItem);

        MenuItem Delete(MenuItem menuItem);

        MenuItem Edit(MenuItem menuItem);

        MenuItem Read(MenuItem menuItem);

        MenuItem List(MenuItem menuItem);
    }
}
