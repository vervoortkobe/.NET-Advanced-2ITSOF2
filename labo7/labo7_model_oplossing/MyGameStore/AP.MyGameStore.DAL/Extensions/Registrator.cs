using AP.MyGameStore.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AP.MyGameStore.DAL.Extensions
{
    public static class Registrator
    {
        public static IServiceCollection RegisterDAL(this IServiceCollection services)
        {
            services.RegisterDbContext();
            //services.RegisterRepositories();
            return services;
        }
        private static IServiceCollection RegisterDbContext(this IServiceCollection services)
        {
            services.AddDbContext<GameStoreContext>(options =>
                        options.UseSqlServer("name=ConnectionStrings:MyGameStore"));

            return services;
        }

        //private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        //{
        //    services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        //    services.AddScoped(typeof(IPeopleRepository), typeof(PeopleRepository));

        //    return services;
        //}
    }
}
