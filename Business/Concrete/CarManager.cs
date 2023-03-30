using Business.Abstract;
using Business.Constains;
using core.Utilities.Results;
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


        public CarManager(ICarDal carDal, IBrandDal brandDal, IColorDal colorDal)
        {
            _carDal = carDal;
            _brandDal = brandDal;
            _colorDal = colorDal;
        }


        public IResult add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccesResult(Messages.CarAdded);
        }

        public IResult delete(Car car)
        {
            _carDal.delete(car);
            return new SuccesResult();
        }

        

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==19)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Arabalar Listelendi");

           

        }

        public SuccessDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBlandId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c  => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<Car>> GetCarsByModelYear()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ModelYear>2002));
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccesResult();  

        }

       
    }
}
