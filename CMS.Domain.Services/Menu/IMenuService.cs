namespace CMS.Domain.Services.Menus
{
    public interface IMenuService
    {
        Menu Create(Menu menu);

        Menu Delete(Menu menu);

        Menu Edit(Menu menu);

        Menu Read(Menu menu);

        Menu List(Menu menu);

    }
}
