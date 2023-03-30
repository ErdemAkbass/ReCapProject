using core.dataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
           using(RentCarContext context=new RentCarContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.Id
                             select new CarDetailsDto
                             {
                                 CarName=p.CarName,
                                 ıd=p.Id,
                                 BrandName = c.BrandName
                             };
                return result.ToList();

            }

        }
    }

}

