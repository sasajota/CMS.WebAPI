using CMS.Data.Interfaces;
using CMS.Domain;

namespace CMS.Data.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly CMSContext _cmsContext;

        public ArticleRepository(CMSContext cmsContext)
        {
            _cmsContext = cmsContext;
        }

        public Article Create(Article article)
        {
            _cmsContext.Articles.Add(article);
            _cmsContext.SaveChanges();
            return article;
        }

        public Article Delete(Article article)
        {
            _cmsContext.Articles.Remove(article);
            _cmsContext.SaveChanges();
            return article;
        }

        public Article Edit(Article article)
        {
            _cmsContext.Articles.Update(article);
            _cmsContext.SaveChanges();
            return article;
        }

        public Article List(Article article)
        {
            throw new System.NotImplementedException();
        }

        public Article Read(Article article)
        {
            throw new System.NotImplementedException();
        }
    }
}
