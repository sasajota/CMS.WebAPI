using CMS.Domain;
using System.Collections.Generic;

namespace CMS.Data.Interfaces
{
    public interface IArticleCategoryRepository
    {
        ArticleCategory Create(ArticleCategory articleCategories);

        ArticleCategory Delete(ArticleCategory articleCategories);

        ArticleCategory Edit(ArticleCategory articleCategories);

        ArticleCategory Read(int articleCategoriesId);

        IEnumerable<ArticleCategory> List();
    }
}
