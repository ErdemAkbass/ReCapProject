using core.Utilities.Results;
using Entities.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        
        IDataResult<List<Car>> GetCarsByBlandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IResult add(Car car);
        IResult delete(Car car);

        IResult Update(Car car);

        SuccessDataResult<List<CarDetailsDto>> GetCarDetails();
    
}
}
