using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using static AP.MyGameStore.DAL.Interfaces.IStoresRepository;

namespace AP.MyGameStore.DAL.Repositories
{
    public class StoresRepository : GenericRepository<Store>, IStoresRepository
    {

        public StoresRepository(GameStoreContext context): base(context)
        {

        }

        public PagedResult<Store> GetAll(string? nameFilter = null, IStoresRepository.SortBy? sortBy= null, int pageNumber = 1, int pageLength = 10)
        {
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

            //Then sorting (if required)
            switch (sortBy)
            {
                case SortBy.ByNameAscending:
                    query = query.OrderBy(s => s.Name);
                    break;
                case SortBy.ByNameDescending:
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

        public Store GetByName(string name)
        {
            return context.Stores.FirstOrDefault(s => s.Name == name);
        }

        public IEnumerable<Person> GetEmployees(int storeId)
        {
            return context.People.Where(p => p.EmployerId == storeId);
        }

        public void RemoveEmployees(int storeId)
        {
            context.People.RemoveRange(context.People.Where(p => p.EmployerId == storeId));
        }
    }
}
