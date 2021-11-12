using Xunit;
using NSubstitute;
using CMS.Data.Interfaces;
using CMS.Domain.Services.Menus;

namespace CMS.Domain.Services.Tests
{
    class MenuServiceTest
    {
        private readonly IMenuRepository menuRepository = Substitute.For<IMenuRepository>();
        private readonly IMenuService menuService;
        public void Create_New_MenuTest()
        {
            // Arrange
            Menu menu = new Menu();
            menuRepository.Create(menu).Returns(menu);

            // Act
            Menu actualMenu = menuService.Create(menu);

            // Assert
            Assert.Same(menu, actualMenu);
        }
    }
}
