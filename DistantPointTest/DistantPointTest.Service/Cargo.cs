using DistantPointTest.Entities;
using DistantPointTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service
{
    public class Cargo : ICargo
    {
        public bool Validation(Courier courier, Package package)
        {
            if (package.cubicCM < courier.MinDimensions)
            {
                return false;
            }
            else if (package.cubicCM > courier.MaxDimensions)
            {
                return false;
            }
            else if (package.Weight < courier.MinWeight)
            {
                return false;
            }
            else if (package.Weight > courier.MaxWeight)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double PricePerDimension(Package package, PricePerCourier courierPricer)       
        {
            var volume = package.cubicCM;
            if (volume >= courierPricer.MinDimensions1 && volume <= courierPricer.MaxDimensions1)
            {
                package.Cost = courierPricer.PriceDimension1;
            }
            else if (volume >= courierPricer.MinDimensions2 && volume <= courierPricer.MaxDimensions2)
            {
                package.Cost = courierPricer.PriceDimension2;
            }
            else if (volume >= courierPricer.MinDimensions3 && volume <= courierPricer.MaxDimensions3)
            {
                package.Cost = courierPricer.PriceDimension3;
            }
            else if (volume >= courierPricer.MinDimensions4 && volume <= courierPricer.MaxDimensions4)
            {
                package.Cost = courierPricer.PriceDimension4;
            }

            return package.Cost;
        }
        
        public double PricePerWeight(Package package, PricePerCourier courierPricer)       
        {
            var weight = package.Weight;
            if (weight >= courierPricer.MinWeight1 && weight <= courierPricer.MaxWeight1)
            {
                package.Cost = courierPricer.PriceWeight1;
            }
            else if (weight >= courierPricer.MinWeight2 && weight <= courierPricer.MaxWeight2)
            {
                package.Cost = courierPricer.PriceWeight2;
            }
            else if (weight >= courierPricer.MinWeight3 && weight <= courierPricer.MaxWeight3)
            {
                package.Cost = courierPricer.PriceWeight3;
            }
            else if (weight >= courierPricer.MinWeight4 && weight <= courierPricer.MaxWeight4)
            {
                package.Cost = courierPricer.PriceWeight4;
            }
            else if(weight > courierPricer.ExtraWeight)
            {
                var extraWeight = weight - courierPricer.ExtraWeight;
                var cost = (extraWeight * courierPricer.AdditionalPrice) + courierPricer.ExtraWeightPrice;
                package.Cost = cost;
            }

            return package.Cost;
        }

        public double FinalPrice(double pricePerWeight, double pricePerDimension)
        {
            double price = 0;
            if (pricePerWeight >= pricePerDimension)
            {
                price = pricePerWeight;
            }
            else
            {
                price = pricePerDimension;
            }

            return price;
        }
    }
}
