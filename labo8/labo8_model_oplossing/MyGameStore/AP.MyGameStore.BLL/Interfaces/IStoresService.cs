using AP.MyGameStore.DAL;
using AP.MyGameStore.DAL.Model;
using static AP.MyGameStore.DAL.Interfaces.IStoresRepository;

namespace AP.MyGameStore.BLL.Interfaces
{
    public interface IStoresService
    {
        public PagedResult<Store> GetAll(string? nameFilter = null, SortBy? sortBy = null, int pageNumber = 1, int pageLength = 10);
        public Store GetById(int id);
        public Store Add(Store store);
        public void Delete(int id);
        public Store Update(Store store);
        public IEnumerable<Person> GetEmployees(int storeId);
        public void DeleteEmployees(int storeId);

        public enum sortBy
        {
            cityAscending,
            cityDescending,
            zipCodeAscending,
            zipcodeDescending
        }
    }

    
}
