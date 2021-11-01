using CMS.Data.Interfaces;
using CMS.Domain;

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
            _cmsContext.Files.Remove(file);
            _cmsContext.SaveChanges();
            return file;
        }

        public File Edit(File file)
        {
            _cmsContext.Files.Update(file);
            _cmsContext.SaveChanges();
            return file;
        }

        public File List(File file)
        {
            throw new System.NotImplementedException();
        }

        public File Read(File file)
        {
            throw new System.NotImplementedException();
        }
    }
}
