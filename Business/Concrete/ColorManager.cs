using Business.Abstract;
using core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IDataResult< List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"Renkler Listelendi");
        } 

        public IDataResult<List<Color>> GetById(int id)
        {
            return new SuccessDataResult<List<Color>> (_colorDal.GetAll(k => k.Id == id));
        }
    }
}
