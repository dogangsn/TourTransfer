using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Domain.Entities
{
    public class Customers : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public int Phone { get; set; } = 0;
        public string EMail { get; set; } = string.Empty;
        public int IdentityNumber { get; set; }
        public string PassaportNumber { get; set; }
        public Adress Adress { get; set; }
       
    }
}
