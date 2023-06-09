﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Domain.Entities
{
    public class Regions : BaseEntity
    {
        public string RegionName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}
