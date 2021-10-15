using DistantPointTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Service.Interfaces
{
    public interface ICourierService
    {
        public void AddCourier(Courier courier);
        public void EditCourier(Courier courier);
        public void DeleteCourier(int id);
        public Courier GetCourierById(int id);
        public IEnumerable<Courier> GetAllCouriers();
    }
}
