using DistantPointTest.Entities;
using DistantPointTest.Repository.Interfaces;
using DistantPointTest.Service.Interfaces;
using System.Collections.Generic;

namespace DistantPointTest.Service
{
    public class PricePerCourierService : IPricePerCourierService
    {
        private readonly IPricePerCourierRepository _pricerPerCourierRepository;

        public PricePerCourierService(IPricePerCourierRepository pricerPerCourierRepository)
        {
            _pricerPerCourierRepository = pricerPerCourierRepository;
        }

        public void AddPricer(PricePerCourier pricer)
        {
            _pricerPerCourierRepository.AddPricer(pricer);
        }

        public void DeletePricer(int id)
        {
            _pricerPerCourierRepository.DeletePricer(id);
        }

        public void EditPricer(PricePerCourier pricer)
        {
            _pricerPerCourierRepository.EditPricer(pricer);
        }

        public IEnumerable<PricePerCourier> GetAllPricers()
        {
            var result = _pricerPerCourierRepository.GetAllPricers();
            return result;
        }

        public PricePerCourier GetPricerByCourierId(int id)
        {
            var result = _pricerPerCourierRepository.GetPricerByCourierId(id);
            return result;
        }

        public PricePerCourier GetPricerById(int id)
        {
            var result = _pricerPerCourierRepository.GetPricerById(id);
            return result;
        }
    }
}
