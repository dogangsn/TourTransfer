using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTransfer.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime RecordDate { get; set; }
        public string RecordUser { get; set; } = string.Empty;
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; } = string.Empty;
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; } = string.Empty;
    }
}
