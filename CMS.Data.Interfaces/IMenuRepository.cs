using CMS.Domain;

namespace CMS.Data.Interfaces
{
    public interface IMenuRepository
    {
        Menu Create(Menu menu);

        Menu Delete(Menu menu);

        Menu Edit(Menu menu);

        Menu Read(Menu menu);

        Menu List(Menu menu);
    }
}
