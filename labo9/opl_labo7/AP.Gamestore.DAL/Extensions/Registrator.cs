using AP.MyGameStore.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.DAL.Extensions
{
    public static class Registrator
    {
        public static IServiceCollection RegisterDbContext(this IServiceCollection services)
        {
            services.AddDbContext<MyGameStoreContext>(options =>
                        options.UseSqlServer("name=ConnectionStrings:MyGameStore"));

            return services;
        }
    }
}
