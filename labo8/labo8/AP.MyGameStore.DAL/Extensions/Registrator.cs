using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AP.MyGameStore.DAL.Extensions
{
    public static class Registrator
    {
        public static IServiceCollection RegisterDAL(this IServiceCollection services)
        {
            services.RegisterDbContext();
            return services;
        }

        public static IServiceCollection RegisterDAL(this IServiceCollection services)
        {
            services.AddDbContext<MyGameStoreContext>(options => options.UseSqlServer("name=ConnectionStrings:MyGameStore"));
            return services;
        }
    }
}