using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.BLL.Interfaces;
using Zolando.OrderSystem.BLL.Services;

namespace Zolando.OrderSystem.BLL.Extensions
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
            services.AddScoped<IOrdersService, OrdersService>();
            return services;
        }

    }
}