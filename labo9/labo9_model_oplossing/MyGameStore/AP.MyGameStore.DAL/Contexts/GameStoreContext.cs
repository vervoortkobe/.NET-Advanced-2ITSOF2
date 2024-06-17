using AP.MyGameStore.DAL.Model;
using AP.MyGameStore.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AP.MyGameStore.DAL.Contexts
{
    public class GameStoreContext : DbContext
    {
        public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Store>().Seed();

            modelBuilder.Entity<Person>().Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
