using DistantPointTest.Data;
using DistantPointTest.Entities;
using DistantPointTest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistantPointTest.Repository
{
    public class PricerPerCourierRepository : IPricePerCourierRepository
    {
        private readonly DataContext _dataContext;

        public PricerPerCourierRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddPricer(PricePerCourier pricer)
        {
            _dataContext.PricePerCourier.Add(pricer);
            _dataContext.SaveChanges();
        }

        public void DeletePricer(int id)
        {
            var pricer = GetPricerById(id);
            _dataContext.PricePerCourier.Remove(pricer);
            _dataContext.SaveChanges();
        }

        public void EditPricer(PricePerCourier pricer)
        {
            _dataContext.PricePerCourier.Update(pricer);
            _dataContext.SaveChanges();
        }

        public IEnumerable<PricePerCourier> GetAllPricers()
        {
            var result = _dataContext.PricePerCourier.AsEnumerable();
            return result;
        }

        public PricePerCourier GetPricerByCourierId(int id)
        {
            var result = _dataContext.PricePerCourier.Where(x => x.CourierId == id).FirstOrDefault();
            return result;
        }

        public PricePerCourier GetPricerById(int id)
        {
            var result = _dataContext.PricePerCourier.Where(x => x.PricePerCourierId == id).FirstOrDefault();
            return result;
        }
    }
}
