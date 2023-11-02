
using Academy.Core.Repositories;

namespace Academy.Data.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        List<T> values = new List<T>();
        public async Task CreateAsync(T entity)
        {
           values.Add(entity);
        }

        public async Task<List<T>> GetAllAsync(T entity)
        {
            return values;
        }

        public Task<T> GetAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(T entity)
        {
            values.Remove(entity);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }







    }
}
