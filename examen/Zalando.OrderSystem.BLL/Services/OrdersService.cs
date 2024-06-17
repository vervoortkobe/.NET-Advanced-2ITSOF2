using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.BLL.Exceptions;
using Zolando.OrderSystem.BLL.Interfaces;
using Zolando.OrderSystem.DAL.Interfaces;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.BLL.Services
{
    internal class OrdersService : IOrdersService
    {
        private readonly IUnitOfWork uow;

        public OrdersService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public Order Create(Order order)
        {
                var findOrder = uow.OrdersRepository.Get(order.Id);
                if (findOrder == null)
                    throw new NoDeleteOrderProductsException("The specified order does not exist");

            uow.OrdersRepository.Create(order);
            uow.Commit();
            return order;
        }

        public void Delete(int id)
        {
            var findOrder = uow.OrdersRepository.Get(id);
            if (findOrder == null)
                throw new KeyNotFoundException("the order was not found");

            if (findOrder.Products == null)
                throw new NoDeleteOrderProductsException("the order has products, so it's not deletable");

            uow.OrdersRepository.Delete(id);
            uow.Commit();
        }

        public Order Get(int id)
        {
            return uow.OrdersRepository.Get(id);
        }

        public Order[] GetAll()
        {
            return uow.OrdersRepository.GetAll();
        }

        public Order Update(Order order)
        {
            var findOrder = uow.OrdersRepository.Get(order.Id);
            if (findOrder == null)
                throw new NoDeleteOrderProductsException("The specified order does not exist");

            if (findOrder.Date != order.Date) throw new NoUpdateOrderDateException("the date of the order can't be updated");

            findOrder.Id = order.Id;
            findOrder.Products = order.Products;
            findOrder.Status = order.Status;
            //findOrder.Date = order.Date;
            uow.Commit();
            return findOrder;
        }
    }
}
