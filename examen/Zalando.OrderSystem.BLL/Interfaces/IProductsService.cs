using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.BLL.Interfaces
{
    public interface IProductsService
    {
        public Product[] GetAll();
        public Product Get(int id);
        public Product Create(Product product);
        public void Delete(int id);

    }
}