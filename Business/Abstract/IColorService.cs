using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetColors();
        IDataResult<Color> GetById(int id);
        IResult ColorUpdate(Color color);
        IResult ColorAdd(Color color);
        IResult ColorDelete(Color color);
    }
}
