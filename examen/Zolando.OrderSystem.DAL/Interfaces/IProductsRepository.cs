using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Interfaces
{
    public interface IProductsRepository
    {
        public Product[] GetAll();
        public Product Get(int id);
        public Product Create(Product item);
        public void Delete(int id);
        public Product Update(Product updateItem);
    }
}