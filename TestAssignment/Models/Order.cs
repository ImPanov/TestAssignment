using System.ComponentModel.DataAnnotations.Schema;

namespace Packet.Shared
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateOnly DateOrder { get; set; }
        public required string StoreCity { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
