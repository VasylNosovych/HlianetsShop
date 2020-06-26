using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HlianetsShop.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static void AddContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<HlianetsContext>(options => options.UseSqlServer(connection));
        }
    }
}