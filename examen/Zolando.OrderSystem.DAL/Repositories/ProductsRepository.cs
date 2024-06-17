using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.DAL.Contexts;
using Zolando.OrderSystem.DAL.Interfaces;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Repositories
{

    public class ProductsRepository : IProductsRepository
    {
        protected readonly OrderSystemContext context;

        public ProductsRepository(OrderSystemContext context)
        {
            this.context = context;
        }

        public Product Create(Product item)
        {
            context.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            context.Products.RemoveRange(context.Products.Where(o => o.Id == id));
        }

        public Product Get(int id)
        {
            return context.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product[] GetAll()
        {
            return context.Products.ToArray<Product>();
        }

        public Product Update(Product updateItem)
        {
            context.Update(updateItem);
            return updateItem;
        }
    }
}
