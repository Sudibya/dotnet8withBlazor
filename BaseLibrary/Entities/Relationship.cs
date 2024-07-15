
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Relationship
    {
        // One-to-many relationship with Employee
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
