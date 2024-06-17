using AP.MyGameStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.DAL.Interfaces
{
    public interface IStoresRepository : IGenericRepository<Store>
    {
        PagedResult<Store> GetAll(string? nameFilter = null, SortBy? sortBy = null, int pageNumber = 1, int pageLength = 10);

        public enum SortBy
        {
            ByNameAscending,
            ByNameDescending
        }
        Store GetByName(string name);
        IEnumerable<Person> GetEmployees(int storeId);
        void RemoveEmployees(int storeId);
    }
}
