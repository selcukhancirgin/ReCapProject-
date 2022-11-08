using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetRentals();
        IDataResult<Rental> GetById(int id);
        IResult RentalUpdate(Rental rental);
        IResult RentalAdd(Rental rental);
        IResult RentalDelete(Rental rental);
    }
}
