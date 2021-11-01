using CMS.Data.Interfaces;
using CMS.Domain;

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
            _cmsContext.ArticleCategories.Remove(articleCategory);
            _cmsContext.SaveChanges();
            return articleCategory;
        }

        public ArticleCategory Edit(ArticleCategory articleCategory)
        {
            _cmsContext.ArticleCategories.Update(articleCategory);
            _cmsContext.SaveChanges();
            return articleCategory;
        }

        public ArticleCategory List(ArticleCategory articleCategory)
        {
            throw new System.NotImplementedException();
        }

        public ArticleCategory Read(ArticleCategory articleCategory)
        {
            throw new System.NotImplementedException();
        }
    }
}
