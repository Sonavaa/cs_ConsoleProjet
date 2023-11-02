
using Academy.Core.Enums;
using Academy.Core.Models.BaseModels;

namespace Academy.Core.Models
{
    public class Student : BaseModel
    {
        static int _id;
        public string Id { get; set; }
        public string FullName { get; set; }
        public Education Group { get; set; }
        public int Average { get; set; }

        public Student(int id, string fullName, string group, int average)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            Group = group;
            Average = average;
        }
    }
}
