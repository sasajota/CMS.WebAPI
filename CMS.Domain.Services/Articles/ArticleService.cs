using CMS.Data.Interfaces;
using CMS.Domain.Services.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Domain.Services.Articles
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IEntityStatusValidator _entityStatusValidator;

        public ArticleService(IArticleRepository articleRepository, 
            IEntityStatusValidator entityStatusValidator)
        {
            _articleRepository = articleRepository;
            _entityStatusValidator = entityStatusValidator;
        }

        public Article Create(Article article)
        {
            return _articleRepository.Create(article);
        }

        public Article Delete(Article article)
        {
            _entityStatusValidator.Validate(article.Status);
            return _articleRepository.Delete(article);
        }

        public Article Edit(Article article)
        {
            _entityStatusValidator.Validate(article.Status);
            return _articleRepository.Edit(article);
        }

        public IEnumerable<Article> List()
        {
            return _articleRepository.List().Where(article => article.Status == Status.ACTIVE);
        }

        public Article Read(int id)
        {
            return _articleRepository.Read(id);
        }
    }
}
