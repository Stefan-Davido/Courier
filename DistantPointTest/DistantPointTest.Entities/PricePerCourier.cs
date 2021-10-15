using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Entities
{
    public class PricePerCourier
    {
        public int PricePerCourierId{ get; set; }
        public int CourierId{ get; set; }
        public string CourierName{ get; set; }

        // *** Price per Weight
        public double MinWeight1 { get; set; }
        public double MaxWeight1 { get; set; }
        public double PriceWeight1 { get; set; }
        public double MinWeight2 { get; set; }
        public double MaxWeight2 { get; set; }
        public double PriceWeight2 { get; set; }
        public double MinWeight3 { get; set; }
        public double MaxWeight3 { get; set; }
        public double PriceWeight3 { get; set; }
        public double MinWeight4 { get; set; }
        public double MaxWeight4 { get; set; }
        public double PriceWeight4 { get; set; }
        public double ExtraWeightPrice { get; set; }
        public double AdditionalPrice { get; set; }
        public double ExtraWeight { get; set; }

        // *** Price per Dimensions
        public double MinDimensions1 { get; set; }
        public double MaxDimensions1 { get; set; }
        public double PriceDimension1 { get; set; }
        public double MinDimensions2 { get; set; }
        public double MaxDimensions2 { get; set; }
        public double PriceDimension2 { get; set; }
        public double MinDimensions3 { get; set; }
        public double MaxDimensions3 { get; set; }
        public double PriceDimension3 { get; set; }
        public double MinDimensions4 { get; set; }
        public double MaxDimensions4 { get; set; }
        public double PriceDimension4 { get; set; }

        public virtual ICollection<Package> Package { get; set; }
    }
}
