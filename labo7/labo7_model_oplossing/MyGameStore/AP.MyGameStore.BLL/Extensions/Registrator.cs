using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AP.MyGameStore.BLL.Extensions
{
    public static class Registrator
    {

        public static IServiceCollection RegisterBLL(this IServiceCollection services)
        {
            services.RegisterServices();
            return services;
        }

        private static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IStoresService, StoresService>();
            return services;
        }

    }
}
