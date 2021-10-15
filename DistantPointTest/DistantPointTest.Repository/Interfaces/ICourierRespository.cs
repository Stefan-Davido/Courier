using DistantPointTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistantPointTest.Repository.Interfaces
{
    public interface ICourierRespository
    {
        public void AddCourier(Courier courier);
        public void EditCourier(Courier courier);
        public void DeleteCourier(int id);
        public Courier GetCourierById(int id);
        public IEnumerable<Courier> GetAllCouriers();
    }
}
