﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DeliveryMethod : BaseEntity
    {
        public string Name { get; set; }

        public string? LogoUrl { get; set; }

        public int MinimalPrice { get; set; }
    }
}