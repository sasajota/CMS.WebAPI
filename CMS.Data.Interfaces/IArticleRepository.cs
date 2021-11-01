using CMS.Domain;

namespace CMS.Data.Interfaces
{
    public interface IArticleRepository
    {
        Article Create(Article article);

        Article Delete(Article article);

        Article Edit(Article article);

        Article Read(Article article);

        Article List(Article article);
    }
}
