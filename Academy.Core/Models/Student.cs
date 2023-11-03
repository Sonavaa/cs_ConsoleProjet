
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

        public Student(string id, string fullName, Education group, int average)
        {
            _id++;
            Id = $"{Group.ToString()[0]}-{_id}";
            FullName = fullName;
            Group = group;
            Average = average;
                
        }
    }
}
