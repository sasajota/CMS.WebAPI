namespace CMS.Domain.Services.Files
{
    public interface IFileService
    {
        File Create(File file);

        File Delete(File file);

        File Edit(File file);

        File Read(int id);

        File List(File file);

    }
}
