using DistantPointTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistantPointTest.Models
{
    public class FullCourierViewModel
    {
        public Courier Courier { get; set; }
        public PricePerCourier Pricer { get; set; }
    }
}
