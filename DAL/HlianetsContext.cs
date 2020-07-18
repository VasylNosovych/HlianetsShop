using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class HlianetsContext : DbContext
    {
        public HlianetsContext() { }

        public HlianetsContext(DbContextOptions<HlianetsContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        
        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> Roles { get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }

        
    }
}