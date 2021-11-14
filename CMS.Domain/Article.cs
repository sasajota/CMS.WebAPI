namespace CMS.Domain
{
    public class Article : Auditable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

    }
}