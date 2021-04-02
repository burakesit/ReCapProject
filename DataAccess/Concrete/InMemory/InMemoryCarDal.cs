using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=11,ColorId=21,ModelYear=2020,DailyPrice=120,Description="Gps arızası bulunan bir araçtır."},
                new Car {CarId=2,BrandId=12,ColorId=22,ModelYear=2020,DailyPrice=130,Description="Dizel ve otomatik araçtır."},
                new Car {CarId=3,BrandId=13,ColorId=23,ModelYear=2020,DailyPrice=115,Description="Manuel ve benzinli araçtır."},
                new Car {CarId=4,BrandId=14,ColorId=24,ModelYear=2020,DailyPrice=117,Description="Eski model bir araçtır."},
                new Car {CarId=5,BrandId=15,ColorId=25,ModelYear=2020,DailyPrice=135,Description="Manuel ve otomatik araçtır."},
                new Car {CarId=6,BrandId=16,ColorId=26,ModelYear=2020,DailyPrice=112,Description="Arazi aracıdır."},
                new Car {CarId=7,BrandId=17,ColorId=27,ModelYear=2020,DailyPrice=116,Description="Manuel ve benzinli araçtır."},
                new Car {CarId=8,BrandId=18,ColorId=28,ModelYear=2020,DailyPrice=110,Description="İki kişilik araçtır."},
                new Car {CarId=9,BrandId=19,ColorId=29,ModelYear=2020,DailyPrice=119,Description="Station Vagon Manuel ve benzinli araçtır."},
                new Car {CarId=10,BrandId=20,ColorId=30,ModelYear=2020,DailyPrice=111,Description="Manuel ve dizel araçtır."}
            };
            
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByld()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
