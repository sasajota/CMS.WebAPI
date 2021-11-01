using CMS.Domain;

namespace CMS.Data.Interfaces
{
    public interface IArticleCategoryRepository
    {
        ArticleCategory Create(ArticleCategory articleCategories);

        ArticleCategory Delete(ArticleCategory articleCategories);

        ArticleCategory Edit(ArticleCategory articleCategories);

        ArticleCategory Read(ArticleCategory articleCategories);

        ArticleCategory List(ArticleCategory articleCategories);
    }
}
