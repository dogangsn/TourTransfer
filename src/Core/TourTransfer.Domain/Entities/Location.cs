using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; } = string.Empty; 
        public virtual Adress Adress { get; set; } = new Adress();
        public bool Active { get; set; } = true;
    }
}
