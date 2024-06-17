using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Interfaces
{
    public interface IOrdersRepository
    {
        public Order[] GetAll();
        public Order Get(int id);
        public Order Create(Order item);
        public void Delete(int id);
        public Order Update(Order updateItem);
    }
}
