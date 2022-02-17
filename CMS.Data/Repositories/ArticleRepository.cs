using CMS.Data.Interfaces;
using CMS.Domain;
using System.Collections.Generic;

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

            article.Status = Status.INACTIVE;
            _cmsContext.SaveChanges();
            return article;
        }

        public Article Edit(Article article)
        {
            _cmsContext.Articles.Update(article);
            _cmsContext.SaveChanges();
            return article;
        }

        public IEnumerable<Article> List()
        {
            return _cmsContext.Articles;
        }

        public Article Read(int articleId)
        {
            return _cmsContext.Articles.Find(articleId);
        }
    }
}
