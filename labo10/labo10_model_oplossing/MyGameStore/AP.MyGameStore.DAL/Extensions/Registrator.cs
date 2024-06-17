using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Repositories;
using AP.MyGameStore.DAL.UOW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AP.MyGameStore.DAL.Extensions
{
    public static class Registrator
    {
        public static IServiceCollection RegisterDAL(this IServiceCollection services)
        {
            services.RegisterDbContext();
            services.RegisterRepositories();
            services.RegisterUnitOfWork();
            return services;
        }
        private static IServiceCollection RegisterDbContext(this IServiceCollection services)
        {
            services.AddDbContext<GameStoreContext>(options =>
                        options.UseSqlServer("name=ConnectionStrings:MyGameStore"));

            return services;
        }

        private static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IPeopleRepository), typeof(PeopleRepository));
            services.AddScoped(typeof(IStoresRepository), typeof(StoresRepository));

            return services;
        }
    }
}
