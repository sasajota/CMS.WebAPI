using Xunit;
using NSubstitute;
using CMS.Domain.Services.Files;
using CMS.Data.Interfaces;

namespace CMS.Domain.Services.Tests
{
    class FileServiceTest
    {
        private readonly IFileRepository fileRepository = Substitute.For<IFileRepository>();
        private readonly IFileService fileService;
        public void Create_New_FileTest()
        {
            // Arrange
            File file = new File();
            fileRepository.Create(file).Returns(file);

            // Act
            File actualFile = fileService.Create(file);

            // Assert
            Assert.Same(file, actualFile);
        }
    }
}
