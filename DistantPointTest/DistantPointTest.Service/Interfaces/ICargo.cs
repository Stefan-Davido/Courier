using DistantPointTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service.Interfaces
{
    public interface ICargo
    {
        public bool Validation(Courier courier, Package package);
        public double PricePerDimension(Package package, PricePerCourier courierPricer);
        public double PricePerWeight(Package package, PricePerCourier courierPricer);
        public double FinalPrice(double pricePerWeight, double pricePerDimension);
    }
}
