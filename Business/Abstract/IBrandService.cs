using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetBrands();
        IDataResult<Brand> GetById(int id);
        IResult BrandUpdate(Brand brand);
        IResult BrandAdd(Brand brand);
        IResult BrandDelete(Brand brand);
    }
}
