namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepositoryWithRemove<T> : GenericRepository<T , int>
    {

        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
