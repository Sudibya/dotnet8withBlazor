

namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity // we make it public mean it can be accessed any where.
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? EmployeeId { get; set; }
        public string? FileNumber { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public string? Address { get; set; }
        public string? PhotoNumber { get; set; }
        public string? Photo { get; set; }
        public string? Other { get; set; }

        //Relationship many to one

        public GeneralDepartment? GeneralDepartment { get; set; }  //There are the many to one relationship.
        public int GeneralDepartmentId { get; set; }

        public Department? Department { get; set; }
        public int DepartmentId { get; set; }

        public Branch? Branch { get; set; }
        public int BranchId { get; set; }

        public Town? Town { get; set; }
        public int TownId { get; set; }

        
    }
}
