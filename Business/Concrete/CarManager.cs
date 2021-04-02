using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        InMemoryCarDal _CarDal;

        public CarManager(InMemoryCarDal carDal)
        {
            _CarDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }
    }
}
