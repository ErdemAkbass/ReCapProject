    using Business.Abstract;
using Business.Constains;
using core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUsersService
    {
        IUsersDal _userDal;

        public UserManager(IUsersDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccesResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.delete(user);
            return new SuccesResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<List<User>> GetById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(r => r.Id == id), Messages.UsersListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccesResult(Messages.UserUpdated);
        }
    }
}
