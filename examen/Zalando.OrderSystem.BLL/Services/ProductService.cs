using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.BLL.Exceptions;
using Zolando.OrderSystem.BLL.Interfaces;
using Zolando.OrderSystem.DAL.Interfaces;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.BLL.Services
{
    internal class ProductsService : IProductsService
    {
        private readonly IUnitOfWork uow;

        public ProductsService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public Product Create(Product product)
        {
            var existing = uow.ProductsRepository.Get(product.Id);
            if (existing == null)
                throw new NoDeleteOrderProductsException("The specified product does not exist");

            uow.ProductsRepository.Create(product);
            uow.Commit();
            return product;
        }

        public void Delete(int id)
        {
            var existing = uow.ProductsRepository.Get(id);
            if (existing == null)
                throw new KeyNotFoundException("the product was not found");

            uow.OrdersRepository.Delete(id);
            uow.Commit();
        }

        public Product Get(int id)
        {
            return uow.ProductsRepository.Get(id);
        }

        public Product[] GetAll()
        {
            return uow.ProductsRepository.GetAll();
        }

        public Product Update(Product item)
        {
            var existing = uow.ProductsRepository.Get(item.Id);
            if (existing == null)
                throw new NoDeleteOrderProductsException("The specified order does not exist");

            existing.Id = item.Id;
            existing.Name = item.Name;
            existing.Orders = item.Orders;
            existing.Price = item.Price;
            existing.Stock = item.Stock;
            uow.Commit();
            return existing;
        }
    }
}
