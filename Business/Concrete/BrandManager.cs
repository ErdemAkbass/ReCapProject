using Business.Abstract;
using core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            return new SuccesResult("Marka Eklendi");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),"Markalar Listelendi");
        }

        public IDataResult<List< Brand> >GetById(int id)
        { 
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p=>p.Id==id));    
        }

      
    }
}
