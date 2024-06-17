using Bogus;
using EFDemo.Model;
using EFLab.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class LabContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var fakeManufacturers = new Faker<Manufacturer>();
            fakeManufacturers.RuleFor(fm => fm.Id, f => -(f.IndexFaker + 1))
                .RuleFor(fm => fm.Name, f => f.Vehicle.Manufacturer());
            var fakeManufacturersList = fakeManufacturers.GenerateBetween(20, 20);
            var min = fakeManufacturersList.Min(fml => fml.Id);

            var fakeCars = new Faker<Car>();
            fakeCars.RuleFor(o => o.Id, g => -(g.IndexFaker + 1))
                .RuleFor(o => o.ManufacturerId, g => g.Random.Int(min, -1))
                .RuleFor(o => o.Model, g => g.Vehicle.Model())
                .RuleFor(o => o.Fuel, g => g.Vehicle.Fuel())
                .RuleFor(o => o.Year, g => g.Date.PastDateOnly(30).Year);

            var fakeCarList = fakeCars.GenerateBetween(1000, 1000);

            modelBuilder.Entity<Manufacturer>().HasData(fakeManufacturersList);
            modelBuilder.Entity<Car>().HasData(fakeCarList);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string for SQL server
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarsLabDb");
            //Log to Console
            optionsBuilder.LogTo(Console.WriteLine,  Microsoft.Extensions.Logging.LogLevel.Information);
            
            
            base.OnConfiguring(optionsBuilder);
        }

    }
}
