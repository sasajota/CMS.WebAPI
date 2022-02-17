using CMS.Domain.Services.Articles;
using System;
using Xunit;
using NSubstitute;
using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;

namespace CMS.Domain.Services.Tests
{
    public class ArticleServiceTest
    {
        private readonly IArticleRepository articleRepository = Substitute.For<IArticleRepository>();
        private readonly IArticleService articleService;
        [Fact]
        public void Create_Article_Test()
        {
            // Arrange
            Article article = new Article
            {
                Name = "TestArticle",
                Status = Status.ACTIVE,
            };
            articleRepository.Create(article).Returns(article);

            // Act
            Article actualArticle = articleService.Create(article);

            // Assert
            Assert.Same(article, actualArticle);
        }

        [Fact]
        public void Delete_Nonexisting_Article_Test()
        {
            // Arrange
            Article article = new Article
            {
                Name = "AlreadyDeletedTestArticle",
                Status = Status.INACTIVE,
            };
            articleRepository.Delete(article).Returns(article);

            // Act
            // Assert
            Assert.Throws<Exception>(() => articleService.Delete(article));

        }
    }
}
