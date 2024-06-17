using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zolando.OrderSystem.DAL.Model
{
    public class Product
    {
        public int Id { get; set; }
        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Number of items in Stock of this product
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// Price for this product
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// List of orderproducts for this product
        /// </summary>
        [JsonIgnore]
        public List<OrderProduct> Orders { get; set; }
    }
}
