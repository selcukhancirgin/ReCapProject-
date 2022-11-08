using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetUsers();
        IDataResult<User> GetById(int id);
        IResult UserUpdate(User user);
        IResult UserAdd(User user);
        IResult UserDelete(User user);
    }
}
