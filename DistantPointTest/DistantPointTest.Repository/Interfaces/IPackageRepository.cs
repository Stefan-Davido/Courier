using DistantPointTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Repository.Interfaces
{
    public interface IPackageRepository
    {
        public void AddPackage(Package package);
        public void EditPackage(Package package);
        public void DeletePackage(int id);
        public Package GetPacakgeById(int id);
        public IEnumerable<Package> GetAllPackage();
        public IEnumerable<Package> GetAllPackageByUserId(string userId);

    }
}
