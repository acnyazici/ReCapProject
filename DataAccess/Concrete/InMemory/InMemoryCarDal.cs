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
            _cars = new List<Car> {
            new Car {CarId=1,BrandId=1,ColorId=3,ModelYear=1984,DailyPrice=84000,Description="Temiz "},
            new Car {CarId=2,BrandId=1,ColorId=4,ModelYear=1999,DailyPrice=43000,Description="Sağlam"},
            new Car {CarId=3,BrandId=2,ColorId=3,ModelYear=1942,DailyPrice=65000,Description="Nadir"},
            new Car {CarId=4,BrandId=2,ColorId=6,ModelYear=1976,DailyPrice=78000,Description="Güçlü"},
            new Car {CarId=5,BrandId=3,ColorId=8,ModelYear=1986,DailyPrice=105000,Description="Mükemmel"}
            }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where(p => p.categoryId == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(prop => prop.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }

    }
}
