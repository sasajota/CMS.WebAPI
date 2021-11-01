using CMS.Data.Interfaces;

namespace CMS.Domain.Services.Files
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;

        public FileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        public File Create(File file)
        {
            return _fileRepository.Create(file);
        }

        public File Delete(File file)
        {
            throw new System.NotImplementedException();
        }

        public File Edit(File file)
        {
            throw new System.NotImplementedException();
        }

        public File List(File file)
        {
            throw new System.NotImplementedException();
        }

        public File Read(int id)
        {
            return _fileRepository.Read(id);
        }
    }
}
