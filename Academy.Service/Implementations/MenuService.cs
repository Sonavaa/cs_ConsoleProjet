using Academy.Core.Enums;
using Academy.Service.Interfaces;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Academy.Service.Implementations
{
    public class MenuService
    {
        IStudentService studentService = new StudentService();
        public async Task RunApp()
        {
            await Menu();
            string Request = Console.ReadLine();
            while (Request != "0")
            {
                switch (Request)
                {
                    case "1":
                        await CreateStudent();
                        break;
                    case "2":
                        await UpdateStudent();
                        break;
                    case "3":
                        await RemoveStudent();
                        break;
                    case "4":
                        await GetStudent();
                        break;
                    case "5":
                        await GetAllStudents();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Value");
                        break;
                }
            }
        }
        public async Task CreateStudent()
        {
            string FullName = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int Average);
            int i = 1;
            foreach(var item in Enum.GetValues(typeof(Education)))
            {
                Console.WriteLine($"{i}.{item}");
                i++;
            }
            int.TryParse(Console.ReadLine(), out int EnumIndex);
            bool IsExist;
            do {
                Console.WriteLine("Add Student Group");
                IsExist = Enum.IsDefined(typeof(Education), (Education)EnumIndex);
            }
            while (!IsExist);
            await studentService.CreateAsync(FullName,(Education)EnumIndex,Average);
        }
        public async Task UpdateStudent()
        {
            string Id = Console.ReadLine();
            string FullName = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int Average);
            int i = 1;
            foreach (var item in Enum.GetValues(typeof(Education)))
            {
                Console.WriteLine($"{i}.{item}");
                i++;
            }
            int.TryParse(Console.ReadLine(), out int EnumIndex);
            bool IsExist;
            do
            {
                Console.WriteLine("Add Student Group");
                IsExist = Enum.IsDefined(typeof(Education), (Education)EnumIndex);
            }
            while (!IsExist);
            await studentService.UpdateAsync(Id,FullName, (Education)EnumIndex, Average);
        }
        public async Task RemoveStudent()
        {
            string Id = Console.ReadLine();

            await studentService.RemoveAsync(Id);
        }
        public async Task GetStudent()
        {
            string Id = Console.ReadLine();
            await studentService.GetAsync(Id);
        }
        public async Task GetAllStudents()
        {
            await studentService.GetAllAsync();
        }
        public async Task Menu()
        {
            Console.WriteLine("1.Create Student");
            Console.WriteLine("2.Update Student");
            Console.WriteLine("3.Remove Student");
            Console.WriteLine("4.Get Student");
            Console.WriteLine("5.GetAll Student");
            Console.WriteLine("6.Close");
        }
    }
}
