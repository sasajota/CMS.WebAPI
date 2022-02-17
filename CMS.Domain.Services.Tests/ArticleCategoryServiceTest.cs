using CMS.Domain.Services.Articles;
using System;
using Xunit;
using NSubstitute;
using CMS.Data.Interfaces;
using CMS.Domain.Services.ArticleCategories;

namespace CMS.Domain.Services.Tests
{
    public class ArticleCategoryServiceTest
    {
        private readonly IArticleCategoryRepository articleCategoryRepository = Substitute.For<IArticleCategoryRepository>();
        private readonly IArticleCategoryService articleCategoryService;

        [Fact]
        public void Create_Article_Test()
        {
            // Arrange
            ArticleCategory articleCategory = new ArticleCategory
            {
                Name = "TestArticleCategory",
                Status = Status.ACTIVE,
            };
            articleCategoryRepository.Create(articleCategory).Returns(articleCategory);

            // Act
            ArticleCategory actualArticleCategory = articleCategoryService.Create(articleCategory);

            // Assert
            Assert.Same(articleCategory, actualArticleCategory);
        }

        [Fact]
        public void Delete_Nonexisting_Article_Test()
        {
            // Arrange
            ArticleCategory articleCategory = new ArticleCategory
            {
                Name = "AlreadyDeletedTestArticle",
                Status = Status.INACTIVE,
            };
            articleCategoryRepository.Delete(articleCategory).Returns(articleCategory);

            // Act
            // Assert
            Assert.Throws<Exception>(() => articleCategoryService.Delete(articleCategory));

        }
    }
}
