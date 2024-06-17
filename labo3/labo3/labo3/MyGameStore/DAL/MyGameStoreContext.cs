using Microsoft.EntityFrameworkCore;
using MyGameStore.Configuration;
using MyGameStore.Model;
using MyGameStore.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MyGameStore.DAL
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
            
            modelBuilder.Entity<Store>().Seed();
            modelBuilder.Entity<Person>().Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
