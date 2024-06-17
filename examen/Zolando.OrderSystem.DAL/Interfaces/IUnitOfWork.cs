using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zolando.OrderSystem.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IOrdersRepository OrdersRepository { get; }
        IProductsRepository ProductsRepository { get; }
        void Commit();
    }
}
