using Business.Abstract;
using DataAccess.Abstract;
using Entities.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IColorDal _colorDal;
        IBrandDal _brandDal;


        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public CarManager(IBrandDal brandDal)
        {
            _brandDal= brandDal;
        }
        public CarManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void add(Car car)
        {
            if (car.ModelYear>=2002 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("kurallara uymayan bir araba ekleyemezsiniz");
            }
        }

        public void delete(Car car)
        {
            _carDal.Delete(car);       
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBlandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetCarsByModelYear()
        {
            return _carDal.GetAll(c => c.ModelYear>2002);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);   
        }
    }
}
