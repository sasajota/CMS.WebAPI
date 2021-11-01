namespace CMS.Domain.Services.Users
{
    public interface IUserService
    {
        User Create(User user);

        User Delete(int id);

        User Edit(User user);

        User Read(int id);

        User List(User user);

    }
}
