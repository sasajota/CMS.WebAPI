namespace CMS.Domain
{
    public class Auditable
    {
        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

        public string DeletedAt { get; set; }

        public string CreatedBy { get; set; }
    }
}
