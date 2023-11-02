
namespace Academy.Core.Models.BaseModels
{
    public abstract class BaseModel
    {
        public string Id;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
