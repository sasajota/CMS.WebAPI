using CMS.Data.Interfaces;
using System;

namespace CMS.Domain.Services.ArticleCategories
{
    public class ArticleCategoryService : IArticleCategoryService
    {
        private const string MissingEntityErrorMessage = "Article category does not exist.";
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public ArticleCategory Create(ArticleCategory articleCategory)
        {
            throw new System.NotImplementedException();
        }

        public ArticleCategory Delete(ArticleCategory articleCategory)
        {
            if (articleCategory.Status == Status.ACTIVE)
            {
                return _articleCategoryRepository.Delete(articleCategory);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public ArticleCategory Edit(ArticleCategory articleCategory)
        {
            if (articleCategory.Status == Status.ACTIVE)
            {
                return _articleCategoryRepository.Edit(articleCategory);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public ArticleCategory List(ArticleCategory articleCategory)
        {
            throw new NotImplementedException();
        }

        public ArticleCategory Read(int id)
        {
            return _articleCategoryRepository.Read(id);
        }
    }
}
