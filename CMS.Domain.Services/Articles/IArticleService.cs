using System.Collections.Generic;

namespace CMS.Domain.Services.Articles
{
    public interface IArticleService
    {
        Article Create(Article article);

        Article Delete(Article article);

        Article Edit(Article article);

        Article Read(int id);

        IEnumerable<Article> List();

    }
}
