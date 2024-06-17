using AP.MyGameStore.DAL.Model;
using AP.MyGameStore.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;

namespace AP.MyGameStore.DAL
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }
}
