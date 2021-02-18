using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userdal)
        {
            _userDal = userdal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User t)
        {
            _userDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var userid in _userDal.GetAll())
            {
                if (userid.Id == id)
                {
                    _userDal.Delete(userid);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.listed);
        }

        public IDataResult<List<User>> GetById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IResult Update(int id, User t)
        {
            foreach (var _user in _userDal.GetAll())
            {
                if (_user.Id == id)
                {
                    _user.Id = t.Id;
                    _user.FirstName = t.FirstName;
                    _user.LastName = t.LastName;
                    _user.Password = t.Password;
                    _user.EMail = t.EMail;

                    return new SuccessResult(Messages.updated);

                }
            }
            return new SuccessResult(Messages.error);
        }
    }
}
