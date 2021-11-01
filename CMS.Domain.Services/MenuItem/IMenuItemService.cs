namespace CMS.Domain.Services.MenuItems
{
    public interface IMenuItemService
    {
        MenuItem Create(MenuItem menuItem);

        MenuItem Delete(MenuItem menuItem);

        MenuItem Edit(MenuItem menuItem);

        MenuItem Read(MenuItem menuItem);

        MenuItem List(MenuItem menuItem);

    }
}
