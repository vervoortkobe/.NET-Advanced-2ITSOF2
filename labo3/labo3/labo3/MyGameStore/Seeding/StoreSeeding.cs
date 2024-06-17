using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Seeding
{
    public static class StoreSeeding
    {
        public static void Seed(this EntityTypeBuilder<Store> modelBuilder)
        {
            modelBuilder.HasData(
                new Store()
                {
                    Id = -1,
                    Name = "ABC",
                    Street = "Ellerman",
                    Number = "10A",
                    Zipcode = "2000",
                    City = "Antwerp",
                    IsFranchiseStore = false,
                    Addition = ""
                }
            );
        }
    }
}
