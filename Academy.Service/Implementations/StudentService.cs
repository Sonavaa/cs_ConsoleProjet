
using Academy.Core.Enums;
using Academy.Core.Models;
using Academy.Core.Repositories;
using Academy.Data.Repositories;
using Academy.Service.Interfaces;
namespace Academy.Service.Implementations
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository = new StudentRepository();
        public async Task<string> CreateAsync(string fullName, string group, Education education, int average)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "FullName can not be empty";
            }

            if (string.IsNullOrWhiteSpace(group))
            {
                return "Group can not be empty";
            }

            if (average < 0 || average > 100)
            {
                return "Average can not be less than 0 and more than 100";
            }


            Student student = new Student(fullName, group, education, average);
            await _studentRepository.CreateAsync(student);
            return "Successfully Created";
        }

        public async Task<string> GetAsync(string Id)
        {
            Student student = await _studentRepository.GetAsync(x => x.Id == Id);
            if (student == null)
                return "Student Not Found!!";

            Console.WriteLine($"Id: {student.Id}, FullName: {student.FullName}, Group: {student.Group}, Average: {student.Average}, Education: {student.Education} ,CreatedAt: {student.CreatedAt}, UpdatedAt: {student.UpdatedAt}");
            return " ";
        }

        public async Task GetAllAsync()
        {
            await _studentRepository.GetAllAsync();
            List<Student> students = await _studentRepository.GetAllAsync();

            if (students.Count == 0)
            {
                Console.WriteLine("No Students Here!");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, FullName: {student.FullName}, Group: {student.Group}, Average: {student.Average}, Education: {student.Education} ,CreatedAt: {student.CreatedAt}, UpdatedAt: {student.UpdatedAt}");
            }
        }

        public async Task<string> RemoveAsync(string Id)
        {
            Student student = await _studentRepository.GetAsync(x => x.Id == Id);
            if (student == null)
                return "Student Not Found!!";
            await _studentRepository.RemoveAsync(student);
            return "Removed Successfully!!";
        }

        public async Task<string> UpdateAsync(string Id, string FullName, string group, Education education, int Average)
        {
            Student student = await _studentRepository.GetAsync(x => x.Id == Id);
            if (student == null)
                return "Student Not Found!!";

            if (string.IsNullOrWhiteSpace(FullName))
                return "FullName can not be empty";

            if (string.IsNullOrWhiteSpace(group))
                return "Group can not be empty";

            if (Average < 0 || Average > 100)
                return "Average can not be less than 0 and more than 100";

            student.Id = Id;
            student.FullName = FullName;
            student.Group = group;
            student.Average = Average;
            student.Education = education;
            student.CreatedAt = DateTime.UtcNow.AddHours(4);
            student.UpdatedAt = DateTime.UtcNow.AddHours(4);
            return "Updated Successfully!!";
        }


    }
}
