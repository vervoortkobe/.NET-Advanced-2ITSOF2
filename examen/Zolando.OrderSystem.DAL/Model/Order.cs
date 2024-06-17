using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zolando.OrderSystem.DAL.Model
{
    public class Order
    {
        public int Id { get; set; }
        /// <summary>
        /// Date a time that the order was created
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        public OrderStatus Status { get; set; } = OrderStatus.New;

        /// <summary>
        /// List of Orderproducts that this order contains
        /// </summary>
        [JsonIgnore]
        public List<OrderProduct> Products { get; set; }
    }

    public enum OrderStatus : byte
    {
        /// <summary>
        /// Newly created order
        /// </summary>
        New,
        /// <summary>
        /// Order is completed and payed
        /// </summary>
        Completed,
        /// <summary>
        /// Order is send to customer
        /// </summary>
        Send
    }
}
