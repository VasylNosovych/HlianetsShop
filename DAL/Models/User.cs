namespace DAL.Models
{
    public class User : IModel
    {
        public uint UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public uint RoleId { get; set; }

        public UserRole Role { get; set; }
    }
}
