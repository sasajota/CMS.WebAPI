using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Data.Interfaces
{
    public interface IFileRepository
    {
        File Create(File file);

        File Delete(File file);

        File Edit(File file);

        File Read(int fileId);

        IEnumerable<File> List();
    }
}
