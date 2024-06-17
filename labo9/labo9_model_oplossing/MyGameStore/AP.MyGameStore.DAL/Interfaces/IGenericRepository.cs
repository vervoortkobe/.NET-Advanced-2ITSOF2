namespace AP.MyGameStore.DAL.Interfaces
{
    public interface IGenericRepository<T>
    {
        T GetById(int id);

        T Create(T item);
        void Update(T item);

        void Delete(T item);
    }
}
