using CMS.Data.Interfaces;

namespace CMS.Domain.Services.Articles
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public Article Create(Article article)
        {
            // TODO: Validacija kompleksnosti passworda
            // TODO: Validacija da je username unique
            // Ako je sve ok, kreiraj korisnika
            return _articleRepository.Create(article);
        }

        public Article Delete(Article article)
        {
            throw new System.NotImplementedException();
        }

        public Article Edit(Article article)
        {
            throw new System.NotImplementedException();
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
