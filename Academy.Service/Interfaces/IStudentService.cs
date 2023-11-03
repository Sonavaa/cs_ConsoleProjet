
using Academy.Core.Enums;

namespace Academy.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<string> CreateAsync(string FullName, Education Group, int Average);
        public Task<string> UpdateAsync(string Id, string FullName, Education Group, int Average);
        public Task<string> RemoveAsync(string Id);
        public Task<string> GetAsync(string Id);
        public Task GetAllAsync();
    }
}
