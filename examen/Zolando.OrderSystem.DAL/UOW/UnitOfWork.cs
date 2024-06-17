using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.DAL.Contexts;
using Zolando.OrderSystem.DAL.Interfaces;

namespace Zolando.OrderSystem.DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrderSystemContext context;
        public IOrdersRepository OrdersRepository { get; private set; }
        public IProductsRepository ProductsRepository { get; private set; }

        public UnitOfWork(OrderSystemContext context,
                            IOrdersRepository ordersRepository,
                            IProductsRepository productsRepository)
        {
            this.context = context;
            this.OrdersRepository = ordersRepository;
            this.ProductsRepository = productsRepository;
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}