using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BlandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BlandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        } 
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int BrandId)
        {
            return _brandDal.Get(c => c.BrandId == BrandId);    
        }
    }
}
