namespace Zolando.OrderSystem.DAL.Model
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        //public Order Order { get; set; }  can also be added if needed
        public int ProductId { get; set; }
        //public Product Product { get; set; } can also be added if needed
        public int Count { get; set; }
    }
}
