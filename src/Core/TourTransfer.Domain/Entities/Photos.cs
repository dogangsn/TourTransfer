﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Domain.Common;

namespace TourTransfer.Domain.Entities
{
    public class Photos : BaseEntity
    {
        public Guid PhotoOwnerId { get; set; }
        public byte Photo { get; set; }
    }
}
