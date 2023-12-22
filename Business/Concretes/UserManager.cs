using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult AddUser(User user)
        {
            IResult result = BusinessRules.Run(CheckIfUserEmail(user.Email));
            if (result != null)
            {
                return result;
            }
            _userDal.Add(user);

            return new SuccessResult(Messages.Addet);
        }

        public IResult DeleteUser(User user)
        {
            _userDal.Delete(user);

            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<User>> GetAll()
        {
          return new SuccessDataResult<List<User>>( _userDal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User> (_userDal.Get(u=>u.UserId==userId));
        }

        public IResult UpdateUser(User user)
        {
           _userDal.Update(user);
            return new SuccessResult(Messages.Update);
        }

        private IResult CheckIfUserEmail(string email)
        {
            var result =_userDal.GetAll(u=>u.Email== email).Any();

            if (result)
            {
                return new ErrorResult(Messages.EmailErroro);
            }

            return new SuccessResult();

        }
    }
}
