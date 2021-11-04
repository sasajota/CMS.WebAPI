using CMS.Data.Interfaces;
using System;

namespace CMS.Domain.Services.Files
{
    public class FileService : IFileService
    {
        private const string MissingEntityErrorMessage = "File does not exist.";
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
            if (file.Status == Status.ACTIVE)
            {
                return _fileRepository.Delete(file);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public File Edit(File file)
        {
            if (file.Status == Status.ACTIVE)
            {
                return _fileRepository.Edit(file);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public File List(File file)
        {
            throw new NotImplementedException();
        }

        public File Read(int id)
        {
            return _fileRepository.Read(id);
        }
    }
}
