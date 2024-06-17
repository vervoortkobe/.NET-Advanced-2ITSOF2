using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.BLL.Extensions
{
    public static class Registrator
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IStoresService, StoresService>();
            return services;
        }

    }
}
