using DistantPointTest.Data;
using DistantPointTest.Entities;
using DistantPointTest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistantPointTest.Repository
{
    public class CourierRespositor : ICourierRespository
    {
        private readonly DataContext _dataContext;

        public CourierRespositor(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddCourier(Courier courier)
        {
            _dataContext.Courier.Add(courier);
            _dataContext.SaveChanges();
        }

        public void DeleteCourier(int id)
        {
            var courier = GetCourierById(id);
            _dataContext.Courier.Remove(courier);
            _dataContext.SaveChanges();
        }

        public void EditCourier(Courier courier)
        {
            _dataContext.Courier.Update(courier);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Courier> GetAllCouriers()
        {
            var result = _dataContext.Courier.AsEnumerable();
            return result;
        }

        public Courier GetCourierById(int id)
        {
            var result = _dataContext.Courier.FirstOrDefault(x => x.CourierId == id);
            return result;
        }
    }
}
