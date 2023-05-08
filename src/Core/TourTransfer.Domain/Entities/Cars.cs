using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Domain.Entities
{
    public class Cars : BaseEntity 
    {
        public int CarsStatus { get; set; } 
        public Guid DriverId { get; set; }
        public int CarsNumber { get; set; }
        public int CarsType { get; set; }
        [MaxLength(4)]
        public int ModelYear { get; set; } = 1900;
        public string Color { get; set; } = string.Empty;
        public int PassengerCapacity { get; set; } = 0;
        public int LuggageCapacity { get; set; } = 0;
        public string PlateNumber { get; set; } = string.Empty;
        public List<Photos> Photos { get; set; }

    }
}
