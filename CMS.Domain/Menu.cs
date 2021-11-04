namespace CMS.Domain
{
    public class Menu : Auditable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }

    }
}