
using Academy.Core.Enums;
using Academy.Core.Repositories;
using Academy.Data.Repositories;
using Academy.Service.Interfaces;

namespace Academy.Service.Implementations 
{ 
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository = new StudentRepository();
        public async Task<string> CreateAsync(string Id, string FullName, Education Group, int Average)
        {
            if (string.IsNullOrWhiteSpace(FullName))
                return "FullName can not be empty";
            
            if (string.IsNullOrWhiteSpace(Id))
                return "FullName can not be empty";

            if (Average < 0 && Average > 100)
                return "Average can not be less than 0 and more than 100";

    
        }

        public Task<string> GetAllAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(string Id, string FullName, string Group, int Average)
        {
            throw new NotImplementedException();
        }
    }
}
