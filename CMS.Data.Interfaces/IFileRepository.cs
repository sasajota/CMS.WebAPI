using CMS.Domain;

namespace CMS.Data.Interfaces
{
    public interface IFileRepository
    {
        File Create(File file);

        File Delete(File file);

        File Edit(File file);

        File Read(File file);

        File List(File file);
    }
}
