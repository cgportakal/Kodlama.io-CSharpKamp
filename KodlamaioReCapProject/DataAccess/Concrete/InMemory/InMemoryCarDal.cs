using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //Bu verileri bir veritabanından geliyormuş gibi simüle diyor.
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId=1, ColorId=1, DailyPrice=145000, ModelYear= "2021", Description="Mercedes"},
                new Car{CarId = 2, BrandId=2, ColorId=2, DailyPrice=125023, ModelYear= "2020", Description="BMW"},
                new Car{CarId = 3, BrandId=3, ColorId=3, DailyPrice=225082, ModelYear= "2019", Description="Range Rover"},
                new Car{CarId = 4, BrandId=4, ColorId=4, DailyPrice=132099, ModelYear= "2018", Description="Mitsubishi"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ - Language Integrated Query işlemleri
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            //Gönderdiğim carid'sine sahip olan carid'sini bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
