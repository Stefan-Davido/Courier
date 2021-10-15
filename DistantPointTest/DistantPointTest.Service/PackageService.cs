using DistantPointTest.Entities;
using DistantPointTest.Repository.Interfaces;
using DistantPointTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service
{
    public class PackageService : IPackageService
    {
        private readonly IPackageRepository _packageRepository;

        public PackageService(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public void AddPackage(Package package)
        {
            _packageRepository.AddPackage(package);
        }

        public void DeletePackage(int id)
        {
            _packageRepository.DeletePackage(id);
        }

        public void EditPackage(Package package)
        {
            _packageRepository.EditPackage(package);
        }

        public IEnumerable<Package> GetAllPackage()
        {
            var result = _packageRepository.GetAllPackage();
            return result;
        }

        public IEnumerable<Package> GetAllPackageByUserId(string userId)
        {
            var result = _packageRepository.GetAllPackageByUserId(userId);
            return result;
        }

        public Package GetPacakgeById(int id)
        {
            var result = _packageRepository.GetPacakgeById(id);
            return result;
        }
    }
}
