namespace CMS.Domain
{
    public class ArticleCategory : Auditable
    {
        public int Id { get; set; }

        public int ArticleId { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

    }
}