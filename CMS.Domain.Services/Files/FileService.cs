using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Domain.Services.Files
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;
        private readonly IEntityStatusValidator _entityStatusValidator;

        public FileService(IFileRepository fileRepository,
            IEntityStatusValidator entityStatusValidator)
        {
            _fileRepository = fileRepository;
            _entityStatusValidator = entityStatusValidator;
        }

        public File Create(File file)
        {
            return _fileRepository.Create(file);
        }

        public File Delete(File file)
        {
            _entityStatusValidator.Validate(file.Status);
            return _fileRepository.Delete(file);
        }

        public File Edit(File file)
        {
            _entityStatusValidator.Validate(file.Status);
            return _fileRepository.Edit(file);
        }

        public IEnumerable<File> List()
        {
            return _fileRepository.List().Where(file => file.Status == Status.ACTIVE);
        }

        public File Read(int id)
        {
            return _fileRepository.Read(id);
        }
    }
}
