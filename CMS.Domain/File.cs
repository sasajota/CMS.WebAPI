namespace CMS.Domain
{
    public class File : Auditable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

    }
}