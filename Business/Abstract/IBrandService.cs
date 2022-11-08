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
        List<Brand> GetBrands();
        void BrandUpdate(Brand brand);
        void BrandAdd(Brand brand);
        void BrandDelete(Brand brand);
    }
}
