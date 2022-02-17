using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Data.Interfaces
{
    public interface IArticleRepository
    {
        Article Create(Article article);

        Article Delete(Article article);

        Article Edit(Article article);

        Article Read(int articleId);

        IEnumerable<Article> List();
    }
}
