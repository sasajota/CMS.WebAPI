namespace CMS.Domain
{
    public class User : Auditable
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Contact { get; set; }

        public string Password { get; set; }

        public Status Status { get; set; } 

        public UserType Type { get; set; }
    }
}
