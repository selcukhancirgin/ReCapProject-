using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void ColorAdd(Color color)
        {
            _colorDal.Add(color);
        }

        public void ColorDelete(Color color)
        {
            _colorDal.Delete(color);
        }

        public void ColorUpdate(Color color)
        {
            _colorDal.Update(color);
        }

        public List<Color> GetColors()
        {
            return _colorDal.GetAll();
        }
    }
}
