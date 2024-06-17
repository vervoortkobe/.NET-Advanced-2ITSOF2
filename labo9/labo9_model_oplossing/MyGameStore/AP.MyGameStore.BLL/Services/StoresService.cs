using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL;
using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using static AP.MyGameStore.BLL.Interfaces.IStoresService;
using static AP.MyGameStore.DAL.Interfaces.IStoresRepository;

namespace AP.MyGameStore.BLL.Services
{
    public class StoresService : IStoresService
    {
        private readonly IUnitOfWork uow;

        public StoresService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public PagedResult<Store> GetAll(string? nameFilter = null, SortBy? sortBy = null,int pageNumber = 1, int pageLength = 10)
        {
            //check pre-conditions
            if (pageLength > 20)
                throw new ValidationException("PageLength is limited to 20 items", ValidationException.ValidationError.PageLengthGreaterThan20);
            if (pageNumber < 1)
                throw new ValidationException("PageNumber cannot be 0 or negative", ValidationException.ValidationError.PageNumberSmallerThan1);

            return uow.StoresRepository.GetAll(nameFilter, sortBy, pageNumber, pageLength);
        }

        public Store GetById(int id)
        {
            return uow.StoresRepository.GetById(id);
        }

        public Store Add(Store store)
        {
            if (store.Name.Length > 30)
                throw new ValidationException("Store name is too long", ValidationException.ValidationError.NameTooLong);
            var existing = uow.StoresRepository.GetByName(store.Name);
            if (existing != null)
                throw new ValidationException("A store with this name already exists", ValidationException.ValidationError.NameNotUnique);

            uow.StoresRepository.Create(store);
            uow.Commit();
            return store;
        }

        public void Delete(int id)
        {
            var store = uow.StoresRepository.GetById(id);
            if (store == null)
                throw new KeyNotFoundException("the store was not found");

            if (uow.StoresRepository.GetEmployees(id).Count() > 0)
                throw new ValidationException("There are still employees in this store", ValidationException.ValidationError.EmployeesInStore);

            uow.StoresRepository.Delete(store);
            uow.Commit();
        }

        public Store Update(Store store)
        {
            var existing = uow.StoresRepository.GetById(store.Id);
            if (existing == null)
                throw new KeyNotFoundException("The store was not found");

            if (existing.Name != store.Name)
            {
                if (store.Name.Length > 30)
                    throw new ValidationException("Store name is too long", ValidationException.ValidationError.NameTooLong);
                var exists = uow.StoresRepository.GetByName(store.Name);
                if (exists != null)
                    throw new ValidationException("A store with this name already exists", ValidationException.ValidationError.NameNotUnique);
            }

            existing.Name = store.Name;
            existing.Street = store.Street;
            existing.Number = store.Number;
            existing.Zipcode = store.Zipcode;
            existing.City = store.City;
            existing.IsFranchiseStore = store.IsFranchiseStore;
            existing.Addition = store.Addition;

            uow.Commit();
            return existing;
        }

        public IEnumerable<Person> GetEmployees(int storeId)
        {
            return uow.StoresRepository.GetEmployees(storeId);
        }

        public void DeleteEmployees(int storeId)
        {
            uow.StoresRepository.RemoveEmployees(storeId);
            uow.Commit();
        }

        
    }
}
