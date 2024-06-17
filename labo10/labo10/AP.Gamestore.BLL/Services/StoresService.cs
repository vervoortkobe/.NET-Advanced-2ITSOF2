using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AP.MyGameStore.BLL.Interfaces.IStoresService;

namespace AP.MyGameStore.BLL.Services
{
    public class StoresService : IStoresService
    {
        private readonly MyGameStoreContext context;

        public StoresService(MyGameStoreContext context)
        {
            this.context = context;
        }
        public IEnumerable<Store> GetAll(int pageNr, int pageSize, sortBy orderBy, string city, string zipCode)
        {
            IQueryable<Store> ctxt = context.Stores;
            if (!string.IsNullOrEmpty(city))
                ctxt = ctxt.Where(s => s.City.Contains(city));
            if (!string.IsNullOrWhiteSpace(zipCode))
                ctxt = ctxt.Where(s => s.Zipcode == zipCode);

            switch (orderBy)
            {
                case sortBy.cityAscending:
                    ctxt = ctxt.OrderBy(s => s.City);
                    break;
                case sortBy.cityDescending:
                    ctxt = ctxt.OrderByDescending(s => s.City);
                    break;
                case sortBy.zipCodeAscending:
                    ctxt = ctxt.OrderBy(s => s.Zipcode);
                    break;
                case sortBy.zipcodeDescending:
                    ctxt = ctxt.OrderByDescending(s => s.Zipcode);
                    break;
                default:
                    break;
            }
            return ctxt.Skip((pageNr - 1) * pageSize).Take(pageSize);
        }

        public Store GetById(int id)
        {
            return context.Stores.FirstOrDefault(p => p.Id == id);
        }

        public Store Add(Store store)
        {
            var existing = context.Stores.FirstOrDefault(s => s.Name == store.Name);
            if (existing != null)
                throw new ValidationException("A store with this name already exists");

            context.Stores.Add(store);
            context.SaveChanges();
            return store;
        }

        public void Delete(int id)
        {
            var store = context.Stores.FirstOrDefault(p => p.Id == id);
            if (store == null)
                throw new KeyNotFoundException("the store was not found");

            if (context.People.Any(p => p.EmployerId == store.Id))
                throw new ValidationException("There are still employees in this store");

            context.Stores.Remove(store);
            context.SaveChanges();
        }

        public Store Update(Store store)
        {
            var existing = context.Stores.FirstOrDefault(p => p.Id == store.Id);
            if (existing == null)
                throw new KeyNotFoundException("The store was not found");

            if (existing.Name != store.Name)
            {
                var exists = context.Stores.FirstOrDefault(s => s.Name == store.Name);
                if (exists != null)
                    throw new ValidationException("A store with this name already exists");
            }

            existing.Name = store.Name;
            existing.Street = store.Street;
            existing.Number = store.Number;
            existing.Zipcode = store.Zipcode;
            existing.City = store.City;
            existing.IsFranchiseStore = store.IsFranchiseStore;
            existing.Addition = store.Addition;

            //context.Stores.Update(existing);
            context.SaveChanges();
            return existing;
        }

        public IEnumerable<Person> GetEmployees(int storeId)
        {
            return context.People.Where(p => p.EmployerId == storeId);
        }

        public void DeleteEmployees(int storeId)
        {
            var list = context.People.Where(p => p.EmployerId == storeId);
            context.People.RemoveRange(list);
            context.SaveChanges();
        }
    }
}
