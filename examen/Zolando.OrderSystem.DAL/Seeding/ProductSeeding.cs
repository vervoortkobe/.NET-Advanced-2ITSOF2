using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Seeding
{
    public static class ProductSeeding
    {
        public static void Seed(this EntityTypeBuilder<Product> modelBuilder)
        {
            modelBuilder.HasData(
                new Product()
                {
                    Id = -1,
                    Name = "Karl Kani Winterjas",
                    Price = 169.95,
                    Stock = 10   //10 of these jackets currently in stock
                },
                new Product()
                {
                    Id = -2,
                    Name = "INDICODE JEANS Winterjas",
                    Price = 138.10,
                    Stock = 5
                },
                new Product()
                {
                    Id = -3,
                    Name = "Daniel Hills REGULAR FIT - Winterjas",
                    Price = 205.59,
                    Stock = 2
                },
                new Product()
                {
                    Id = -4,
                    Name = "Jack & Jones JJWARRIOR HOOD - Hoodie",
                    Price = 145.95,
                    Stock = 1
                }

            );
        }
    }
}
