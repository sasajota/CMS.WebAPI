using System.Collections.Generic;

namespace CMS.Domain.Services.ArticleCategories
{
    public interface IArticleCategoryService
    {
        ArticleCategory Create(ArticleCategory articleCategory);

        ArticleCategory Delete(ArticleCategory articleCategory);

        ArticleCategory Edit(ArticleCategory articleCategory);

        ArticleCategory Read(int id);

        IEnumerable<ArticleCategory> List();
    }
}
