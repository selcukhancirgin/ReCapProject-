using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult ColorAdd(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        public IResult ColorDelete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IResult ColorUpdate(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(x => x.ColorId == id), Messages.ListedSuccesfully);
        }

        public IDataResult<List<Color>> GetColors()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ListedSuccesfully);
        }
    }
}
