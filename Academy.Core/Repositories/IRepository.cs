
namespace Academy.Core.Repositories
{
    public interface IRepository<T>
    {
        public Task CreateAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task RemoveAsync(T entity);
        public Task<T> GetAsync(T entity);
        public Task<List<T>> GetAllAsync(T entity);
    }
}
