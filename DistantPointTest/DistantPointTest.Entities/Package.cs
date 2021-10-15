using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Entities
{
    public class Package
    {
        public int PackageId { get; set; }
        public string UserId { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }
        public string CourierName { get; set; }
        public int CourierId { get; set; }
        public double Cost { get; set; }
        public double cubicCM
        {
            get => Width * Height * Depth;
            set
            {
                cubicCM = value;
            }
        }

        public virtual ICollection<IdentityUser> IdentityUser { get; set; }

        public virtual double BasedOnDimensions(Package package)
        {
            return package.Cost;
        }

        public virtual double BasedOnWeight(Package package)
        {
            return package.Cost;
        }

        public virtual bool ValidationCheck(double Weight, double Dimension)
        {
            return false;
        }
    }
}
