using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zolando.OrderSystem.DAL.Interfaces;
using Zolando.OrderSystem.DAL.UOW;
using Zolando.OrderSystem.DAL.Repositories;

namespace Zolando.OrderSystem.DAL.Extensions
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
            services.AddDbContext<OrderSystemContext>(options =>
                        options.UseSqlServer("name=ConnectionStrings:OrderSystem"));

            return services;
        }

        private static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IOrdersRepository), typeof(OrdersRepository));

            return services;
        }
    }
}