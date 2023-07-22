using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packet.Shared
{
    public class Note
    {
        public int NoteId { get; set; }
        public int InvoiceNumber { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
