using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetails> GetCarDetails()
        {
            using (Context context = new Context())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join br in context.Brands
                             on c.BrandId equals br.BrandId
                             select new CarDetails {
                                 CarName = c.Description,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice };

                return result.ToList();       
            }
        }
    }
}
