using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Zolando.OrderSystem.DAL.Model;
using Zolando.OrderSystem.DAL.Seeding;

namespace Zolando.OrderSystem.DAL.Contexts
{
    public class OrderSystemContext : DbContext
    {
        public OrderSystemContext(DbContextOptions<OrderSystemContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Seed();
            modelBuilder.Entity<Order>().Seed();
            modelBuilder.Entity<OrderProduct>().Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
