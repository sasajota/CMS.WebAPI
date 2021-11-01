namespace CMS.Domain.Services.MenuItems
{
    public interface IMenuItemService
    {
        MenuItem Create(MenuItem menuItem);

        MenuItem Delete(MenuItem menuItem);

        MenuItem Edit(MenuItem menuItem);

        MenuItem Read(int id);

        MenuItem List(MenuItem menuItem);

    }
}
