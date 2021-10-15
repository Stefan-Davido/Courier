using DistantPointTest.Entities;
using DistantPointTest.Repository.Interfaces;
using DistantPointTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service
{
    public class CourierService : ICourierService
    {
        private readonly ICourierRespository _courierRespository;

        public CourierService(ICourierRespository courierRespository)
        {
            _courierRespository = courierRespository;
        }

        public void AddCourier(Courier courier)
        {
            _courierRespository.AddCourier(courier);
        }

        public void DeleteCourier(int id)
        {
            _courierRespository.DeleteCourier(id);
        }

        public void EditCourier(Courier courier)
        {
            _courierRespository.EditCourier(courier);
        }

        public IEnumerable<Courier> GetAllCouriers()
        {
            var result = _courierRespository.GetAllCouriers();
            return result;
        }

        public Courier GetCourierById(int id)
        {
            var result = _courierRespository.GetCourierById(id);
            return result;
        }
    }
}
