using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetCustomers();
        IDataResult<Customer> GetById(int id);
        IResult CustomerUpdate(Customer customer);
        IResult CustomerAdd(Customer customer);
        IResult CustomerDelete(Customer customer);
    }
}
