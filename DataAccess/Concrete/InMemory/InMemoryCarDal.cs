using DataAccess.Abstract;
using Entity.Concrete;
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
            _cars = new List<Car>
            {
                new Car{Id=1,CarName="mercedes ",BrandId=2,ColorId=3,ModelYear=2010,DailyPrice="c200d"},
                new Car{Id=2,CarName="mercedes ",BrandId=2,ColorId=2,ModelYear=2015,DailyPrice="AMG"},
                new Car{Id=3,CarName="Audi",BrandId=3,ColorId=5,ModelYear=2019,DailyPrice="A8"},
                new Car{Id=4,CarName="BMW ",BrandId=4,ColorId=3,ModelYear=2022,DailyPrice="520d"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;

            //foreach (var c in _cars)
            //{
            //    if (car.Id==c.Id)
            //    {
            //        carToDelete = c;
            //    }
            //}
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(car);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToDelete.Id = car.Id;
            carToDelete.CarName = car.CarName;
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.DailyPrice = car.DailyPrice;        
        }
    }
}
