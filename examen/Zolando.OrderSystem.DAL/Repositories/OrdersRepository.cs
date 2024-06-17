using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.DAL.Contexts;
using Zolando.OrderSystem.DAL.Interfaces;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Repositories
{

    public class OrdersRepository : IOrdersRepository
    {
        protected readonly OrderSystemContext context;

        public OrdersRepository(OrderSystemContext context)
        {
                this.context = context;
        }

        public Order Create(Order item)
        {
            context.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            context.Orders.RemoveRange(context.Orders.Where(o => o.Id == id));
        }

        public Order Get(int id)
        {
            return context.Orders.FirstOrDefault(p => p.Id == id);
        }

        public Order[] GetAll()
        {
            return context.Orders.ToArray<Order>();
        }

        public Order Update(Order updateItem)
        {
            context.Update(updateItem);
            return updateItem;
        }
    }
}
