using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Model;
using static AP.MyGameStore.BLL.Interfaces.IStoresService;

namespace AP.MyGameStore.BLL.Services
{
    public class StoresService : IStoresService
    {
        private readonly GameStoreContext context;

        public StoresService(GameStoreContext context)
        {
            this.context = context;
        }
        public PagedResult<Store> GetAll(string? nameFilter = null, SortFilter? filter = null,int pageNumber = 1, int pageLength = 10)
        {
            //check pre-conditions
            if (pageLength > 20)
                throw new ValidationException("PageLength is limited to 20 items");
            if (pageNumber < 1)
                throw new ValidationException("PageNumber cannot be 0 or negative");

            var result = new PagedResult<Store>();
            result.PageNumber = pageNumber;
            result.PageSize = pageLength;

            //Starting to build query taking into account the parameters given
            //As long as we work with IQueryable the actual query is not performed yet (deferred execution)
            IQueryable<Store> query = context.Stores;

            //Also fill in the total number of items already.
            result.TotalRecordCount = query.Count();

            //filtering first
            if (nameFilter != null)
                query = query.Where(s => s.Name.Contains(nameFilter));

            //fill in the filtered count (paging will not change that)
            result.FilteredRecordCount = query.Count();
            //now we can calculate the total number of pages (for the filtered set of results)
            result.TotalNumberOfPages = (int)Math.Ceiling((double)result.FilteredRecordCount / result.PageSize);

            if (pageNumber > result.TotalNumberOfPages)
                throw new ValidationException("The request page does not exist");

            //Then sorting (if required)
            switch (filter)
            {
                case SortFilter.ByNameAscending:
                    query = query.OrderBy(s => s.Name);
                    break;
                case SortFilter.ByNameDescending:
                    query = query.OrderByDescending(s => s.Name);
                    break;
                default:
                    break;
            }
            //paging must be the last step !
            query = query.Skip((pageNumber - 1) * pageLength).Take(pageLength);

            //here the actual query for filtered stores with paging is performed on the DB !
            result.Data = query.ToList();

            return result;
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

        public enum SortFilter
        {
            ByNameAscending,
            ByNameDescending
        }
    }
}
