using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packet.Shared
{
    public class Company
    {
        public int CompanyId { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        [DisplayFormat(DataFormatString = "{0:(###) ###-####}")]
        public required long Phone { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Note> Notes { get; set; } = new List<Note>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

    }
}
