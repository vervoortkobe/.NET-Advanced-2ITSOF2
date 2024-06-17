using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Seeding
{
    public static class OrderSeeding
    {
        public static void Seed(this EntityTypeBuilder<Order> modelBuilder)
        {
            modelBuilder.HasData(
                new Order()
                {
                    Id = -1,
                    Date = new DateTime(2024, 1, 3, 10, 32, 10)
                }
            ); ;
        }
    }
}
