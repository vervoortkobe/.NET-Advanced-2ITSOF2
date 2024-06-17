using Microsoft.EntityFrameworkCore;
using MyGameStore.DAL.Model;
using MyGameStore.DAL.Seeding;
using System.Reflection;

namespace MyGameStore.DAL
{
    public class GamestoreContext : DbContext
    {
        public GamestoreContext(DbContextOptions<GamestoreContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Store> Stores { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PersonConfiguration());
            //modelBuilder.ApplyConfiguration(new StoreConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Store>().Seed();
            modelBuilder.Entity<Person>().Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
