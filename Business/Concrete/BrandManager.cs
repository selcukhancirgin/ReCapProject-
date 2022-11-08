using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void BrandAdd(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void BrandDelete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public void BrandUpdate(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public List<Brand> GetBrands()
        {
            return _brandDal.GetAll();
        }
    }
}
