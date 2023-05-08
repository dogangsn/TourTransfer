using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Domain.Entities
{
    public class Reservation : BaseEntity
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public Guid Arrival { get; set; }
        public Guid Departure { get; set; }
        public Guid CarsId { get; set; }
        public Guid CustomerId { get; set; }
        public string Description { get; set; } = "";
        public int InvoiceTypeId { get; set; }
        public int Adult { get; set; }
        public Guid DriverId { get; set; }

    }
}
