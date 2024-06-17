using AP.MyGameStore.DAL.Model;
using AP.MyGameStore.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AP.MyGameStore.DAL.Contexts
{
    public class MyGameStoreContext : DbContext
    {
        public MyGameStoreContext(DbContextOptions<MyGameStoreContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PersonConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Store>().Seed();
            modelBuilder.Entity<Person>().Seed();
            
        }
    }
}
