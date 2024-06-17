using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Model;

namespace MyGameStore.Seeding
{
    public static class Stores
    {
        public static void Seed(this EntityTypeBuilder<Store> builder)
        {
            builder.HasData(new Store
            {
                Id = -1,
                Name = "Albert Heijn",
                City = "Antwerpen",
                IsFranchiseStore = true,
                Street = "Groenplaats",
                Number = "40",
                Zipcode = "2000",
            });
        }
    }
}
