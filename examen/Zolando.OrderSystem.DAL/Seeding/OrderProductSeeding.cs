using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Seeding
{
    public static class OrderProductSeeding
    {
        public static void Seed(this EntityTypeBuilder<OrderProduct> modelBuilder)
        {
            modelBuilder.HasData(
                new OrderProduct()
                {
                    Id = -1,
                    OrderId = -1,
                    ProductId = -2,
                    Count = 1
                },
                new OrderProduct()
                {
                    Id = -2,
                    OrderId = -1,
                    ProductId = -4,
                    Count = 2
                }
            );
        }
    }
}
