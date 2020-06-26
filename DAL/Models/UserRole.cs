namespace DAL.Models
{
    public class UserRole
    {
        public uint RoleId { get; set; }

        public ERole Role { get; set; }
    }


    public enum ERole
    {
        Admin = 0,
        Guest = 1
    }

}
