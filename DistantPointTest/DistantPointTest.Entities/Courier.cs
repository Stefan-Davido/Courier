using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Entities
{
    public class Courier
    {
        public int CourierId { get; set; }
        public int PricerId { get; set; }
        public string CourierName { get; set; }
        public double MaxDimensions { get; set; }
        public double MinDimensions { get; set; }
        public double MinWeight { get; set; }
        public double MaxWeight { get; set; }
        public int OrdersMade { get; set; }

    }
}
