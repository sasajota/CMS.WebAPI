namespace CMS.Domain.Services.ArticleCategories
{
    public interface IArticleCategoryService
    {
        ArticleCategory Create(ArticleCategory articleCategory);

        ArticleCategory Delete(ArticleCategory articleCategory);

        ArticleCategory Edit(ArticleCategory articleCategory);

        ArticleCategory Read(int id);

        ArticleCategory List(ArticleCategory articleCategory);
    }
}
