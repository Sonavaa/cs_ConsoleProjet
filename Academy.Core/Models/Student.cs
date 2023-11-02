
namespace Academy.Core.Models
{
    public class Student
    {
        int _id;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Group { get; set; }
        public int Average { get; set; }

        public Student(int id, string fullName, string group, int average)
        {
            _id++;
            Id = _id;
            FullName= fullName;
            Group = group;
            Average = average;
        }
    }
}
