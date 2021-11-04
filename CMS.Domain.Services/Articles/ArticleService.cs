using CMS.Data.Interfaces;
using System;

namespace CMS.Domain.Services.Articles
{
    public class ArticleService : IArticleService
    {
        private const string MissingEntityErrorMessage = "Article does not exist.";
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public Article Create(Article article)
        {
            return _articleRepository.Create(article);
        }

        public Article Delete(Article article)
        {
            if (article.Status == Status.ACTIVE)
            {
                return _articleRepository.Delete(article);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public Article Edit(Article article)
        {
            if (article.Status == Status.ACTIVE)
            {
                return _articleRepository.Edit(article);
            }
            throw new Exception(MissingEntityErrorMessage);
        }

        public Article List(Article article)
        {
            throw new NotImplementedException();
        }

        public Article Read(int id)
        {
            return _articleRepository.Read(id);
        }
    }
}
