using DistantPointTest.Data;
using DistantPointTest.Entities;
using DistantPointTest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistantPointTest.Repository
{
    public class PackageRepository : IPackageRepository
    {
        private readonly DataContext _dataContext;

        public PackageRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddPackage(Package package)
        {
            _dataContext.Packages.Add(package);
            _dataContext.SaveChanges();
        }

        public void DeletePackage(int id)
        {
            var pacakge = GetPacakgeById(id);
            _dataContext.Remove(pacakge);
            _dataContext.SaveChanges();
        }

        public void EditPackage(Package package)
        {
            _dataContext.Packages.Update(package);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Package> GetAllPackage()
        {
            var result = _dataContext.Packages.AsEnumerable();
            return result;
        }

        public IEnumerable<Package> GetAllPackageByUserId(string userId)
        {
            var result = _dataContext.Packages.Where(x => x.UserId == userId).AsEnumerable();
            return result;
        }

        public Package GetPacakgeById(int id)
        {
            var result = _dataContext.Packages.FirstOrDefault(x => x.PackageId == id);
            return result;
        }
    }
}
