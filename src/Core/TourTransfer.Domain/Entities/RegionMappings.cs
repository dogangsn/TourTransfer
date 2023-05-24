using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Domain.Entities
{
    public class RegionMappings : BaseEntity
    {
        public Guid StartingLocationId { get; set; }
        public Guid EndingLocationId { get; set; }
        public int TotalDistance { get; set; } = 0;
        public decimal TotalAmount { get; set; } = 0;
    }
}
