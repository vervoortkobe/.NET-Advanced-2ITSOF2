using System.Reflection;
using System;
using Zolando.OrderSystem.DAL;
using Zolando.OrderSystem.DAL.Model;
using static Zolando.OrderSystem.DAL.Interfaces.IOrdersRepository;

namespace Zolando.OrderSystem.BLL.Interfaces
{
    public interface IOrdersService
    {
        public Order[] GetAll();
        public Order Get(int id);
        public Order Create(Order order);
        public void Delete(int id);
        public Order Update(Order person);
    } 
}
