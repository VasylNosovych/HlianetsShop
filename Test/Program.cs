//using DAL;
//using DAL.Models;
//using DAL.UnitOfWork;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using System.IO;

//namespace HlianetsShop
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = new ConfigurationBuilder();
//            builder.SetBasePath(Directory.GetCurrentDirectory());
//            builder.AddJsonFile("appsettings.json");

//            var config = builder.Build();
//            string connectionString = config.GetConnectionString("HlianetsDB");

//            var optionsBuilder = new DbContextOptionsBuilder<HlianetsContext>();
//            var options = optionsBuilder
//                .UseSqlServer(connectionString)
//                .Options;

//            using (HlianetsContext db = new HlianetsContext(options))
//            {
//                UserRole admin = new UserRole
//                {
//                    RoleId = 1,
//                    Role = ERole.Admin
//                };
//                UserRole guest = new UserRole
//                {
//                    RoleId = 2,
//                    Role = ERole.Guest
//                };

//                UnitOfWork uow = new UnitOfWork(db);
//                uow.Roles.Create(admin);
//                uow.Roles.Create(guest);
//                uow.Save();
//            }
//        }
//    }
//}
