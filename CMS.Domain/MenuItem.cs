namespace CMS.Domain
{
    public class MenuItem : Auditable
    {
        public int Id { get; set; }

        public int MenuId { get; set; }

        public string Name { get; set; }

    }
}