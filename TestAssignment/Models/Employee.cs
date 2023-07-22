using System.ComponentModel.DataAnnotations.Schema;

namespace Packet.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Title { get; set; }
        public required DateOnly BirthDate { get; set;}
        public required string Post { get; set; }
        public int? CompanyId { get; set; }        
        public Company? Company { get; set; }
    }
}
