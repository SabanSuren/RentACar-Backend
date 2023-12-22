using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
   public  interface IColorService
    {
        IResult AddColor(Color color);

        IResult DeleteColor(Color color);

        IResult UpdateColor(Color color);

        IDataResult<Color> GetById(int ColorId);
        IDataResult< List<Color>> GetAll();
    }
}
