namespace CMS.Domain.Services.Files
{
    public interface IFileService
    {
        File Create(File file);

        File Delete(File file);

        File Edit(File file);

        File Read(File file);

        File List(File file);

    }
}
