using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;
using System;

namespace CMS.Domain.Services.ArticleCategories
{
    public class ArticleCategoryService : IArticleCategoryService
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IEntityStatusValidator _entityStatusValidator;

        public ArticleCategoryService(IArticleCategoryRepository articleCategoryRepository,
            IEntityStatusValidator entityStatusValidator)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _entityStatusValidator = entityStatusValidator;
        }

        public ArticleCategory Create(ArticleCategory articleCategory)
        {
            throw new System.NotImplementedException();
        }

        public ArticleCategory Delete(ArticleCategory articleCategory)
        {
            _entityStatusValidator.Validate(articleCategory.Status);
            return _articleCategoryRepository.Delete(articleCategory);
        }

        public ArticleCategory Edit(ArticleCategory articleCategory)
        {
            _entityStatusValidator.Validate(articleCategory.Status);
            return _articleCategoryRepository.Edit(articleCategory);
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
