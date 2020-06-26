using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class HlianetsContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> Roles { get; set; }
    }
}
