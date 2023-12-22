using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();

        IDataResult<User> GetById(int userId);

        IResult AddUser(User user);


        IResult DeleteUser(User user);

        IResult UpdateUser(User user);
    }
}
