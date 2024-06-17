using AP.MyGameStore.DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP.MyGameStore.DAL.Seeding
{
    public static class StoreSeeding
    {
        public static void Seed(this EntityTypeBuilder<Store> modelBuilder)
        {
            for (int i = 1; i <= 101; i++)
            {
                modelBuilder.HasData(
                new Store()
                {
                    Id = -i,
                    Name = "Store " + i,
                    Street = "StoreStreet",
                    Number = i * 3 + "A",
                    Zipcode = "2000",
                    City = "Antwerp",
                    IsFranchiseStore = new Random().Next(1) > 0,
                    Addition = ""
                }
            );
            }
        }
    }
}
