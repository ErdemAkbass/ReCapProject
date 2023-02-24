using Entities.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBlandId(int id);
        List<Car> GetCarsByColorId(int id);
        void add(Car car);
        void delete(Car car);

        void Update(Car car);

        List<CarDetailsDto> GetCarDetails();
    
}
}
