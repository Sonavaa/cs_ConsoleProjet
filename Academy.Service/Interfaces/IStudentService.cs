
using Academy.Core.Enums;

namespace Academy.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<string> CreateAsync(string fullName, string group,Education education, int average);
        public Task<string> UpdateAsync(string Id, string fullName, string group , Education education, int average);
        public Task<string> RemoveAsync(string Id);
        public Task<string> GetAsync(string Id);
        public Task GetAllAsync();
    }
}
