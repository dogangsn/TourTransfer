﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Domain.Entities
{
    public class Contract : BaseEntity
    {
        //KM başına fiyat girilmesi durumu bu table üstünde tutulacak (F.Z)
        public Guid RegionMappingId { get; set; }
    }
}
