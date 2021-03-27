using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorServices
    {
       IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetColorId(int colorId);
        IDataResult<Color> GetColorName(string colorName);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);

        
    }
}
