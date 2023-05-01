using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTransfer.Application.Models.AdminClient.AdminClientReservation
{
    public class AdminClientReservationDto
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime RecordDate { get; set; }
        public string RecordUser { get; set; } = string.Empty;
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; } = string.Empty;
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public Guid Arrival { get; set; }
        public Guid Departure { get; set; }
        public Guid CarsId { get; set; }
        public Guid CustomerId { get; set; }
        public string Description { get; set; } = "";
        public int InvoiceTypeId { get; set; }
        public int Adult { get; set; }
    }
}
