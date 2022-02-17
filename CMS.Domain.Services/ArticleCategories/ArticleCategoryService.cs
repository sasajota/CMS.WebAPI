using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<ArticleCategory> List()
        {
            return _articleCategoryRepository.List().Where(articleCategory => articleCategory.Status == Status.ACTIVE);
        }

        public ArticleCategory Read(int id)
        {
            return _articleCategoryRepository.Read(id);
        }
    }
}
