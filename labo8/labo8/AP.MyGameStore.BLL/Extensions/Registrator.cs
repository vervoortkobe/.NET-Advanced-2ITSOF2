using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.BLL.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;

namespace AP.MyGameStore.DAL.Extensions
{
    public static class Registrator
    {
        public static IServiceCollection RegisterBLL(this IServiceCollection services)
        {
            services.RegisterServices();
            return services;
        }

        public static IServiceCollection RegisterDAL(this IServiceCollection services)
        {

            services.AddScoped<IPeopleService, using AP.MyGameStore.BLL.Extensions.PeopleService<();
            return services;
        }
    }
}