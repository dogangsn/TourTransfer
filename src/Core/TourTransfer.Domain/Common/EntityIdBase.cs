using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTransfer.Domain.Common
{
    public abstract class EntityIdBase : IBase
    {
        public Guid Id { get; set; }
    }
}
