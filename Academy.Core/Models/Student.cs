using Academy.Core.Enums;
using Academy.Core.Models.BaseModels;

namespace Academy.Core.Models
{
    public class Student : BaseModel
    {
        static int _id;
        public string FullName { get; set; }
        public string Group { get;set; }
        public Education Education { get; set; }
        public int Average { get; set; }

        public Student(string fullName, string group ,Education education, int average)
        {
            _id++;
            FullName = fullName;
            Group = group;
            Education = education;
            Average = average;
            Id = $"{Education.ToString()[0]}-{_id}";

        }
    }
}
