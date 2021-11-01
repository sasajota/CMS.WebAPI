using CMS.Data.Interfaces;

namespace CMS.Domain.Services.ArticleCategories
{
    public class ArticleCategoryService : IArticleCategoryService
    {
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
            throw new System.NotImplementedException();
        }

        public ArticleCategory Edit(ArticleCategory articleCategory)
        {
            throw new System.NotImplementedException();
        }

        public ArticleCategory List(ArticleCategory articleCategory)
        {
            throw new System.NotImplementedException();
        }

        public ArticleCategory Read(int id)
        {
            return _articleCategoryRepository.Read(id);
        }
    }
}
