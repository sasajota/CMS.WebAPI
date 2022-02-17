using CMS.Data.Interfaces;
using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public class FileRepository : IFileRepository
    {
        private readonly CMSContext _cmsContext;

        public FileRepository(CMSContext cmsContext)
        {
            _cmsContext = cmsContext;
        }

        public File Create(File file)
        {
            _cmsContext.Files.Add(file);
            _cmsContext.SaveChanges();
            return file;
        }

        public File Delete(File file)
        {
            file.Status = Status.INACTIVE;
            _cmsContext.SaveChanges();
            return file;
        }

        public File Edit(File file)
        {
            _cmsContext.Files.Update(file);
            _cmsContext.SaveChanges();
            return file;
        }

        public IEnumerable<File> List()
        {
            return _cmsContext.Files;
        }

        public File Read(int fileId)
        {
            return _cmsContext.Files.Find(fileId);
        }
    }
}
