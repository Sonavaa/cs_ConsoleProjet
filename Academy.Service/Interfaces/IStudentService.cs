
namespace Academy.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<string> CreateAsync(string Id, string FullName, string Group, int Average);
        public Task<string> UpdateAsync(string Id, string FullName, string Group, int Average);
        public Task<string> RemoveAsync(string Id);
        public Task<string> GetAllAsync(string Id);
    }
}
