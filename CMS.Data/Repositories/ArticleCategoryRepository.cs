using CMS.Data.Interfaces;
using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly CMSContext _cmsContext;

        public ArticleCategoryRepository(CMSContext cmsContext)
        {
            _cmsContext = cmsContext;
        }

        public ArticleCategory Create(ArticleCategory articleCategory)
        {
            _cmsContext.ArticleCategories.Add(articleCategory);
            _cmsContext.SaveChanges();
            return articleCategory;
        }

        public ArticleCategory Delete(ArticleCategory articleCategory)
        {
            articleCategory.Status = Status.INACTIVE;
            _cmsContext.SaveChanges();
            return articleCategory;
        }

        public ArticleCategory Edit(ArticleCategory articleCategory)
        {
            _cmsContext.ArticleCategories.Update(articleCategory);
            _cmsContext.SaveChanges();
            return articleCategory;
        }

        public IEnumerable<ArticleCategory> List()
        {
            return _cmsContext.ArticleCategories;
        }

        public ArticleCategory Read(int articleCategoryId)
        {
            return _cmsContext.ArticleCategories.Find(articleCategoryId);
        }
    }
}
