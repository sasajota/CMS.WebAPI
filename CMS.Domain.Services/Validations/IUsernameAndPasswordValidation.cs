namespace CMS.Domain.Services.Validations
{
    public interface IUsernameAndPasswordValidation
    {
        bool ValidatePassword(string password);
        bool ValidateUsername(string username);
    }
}
