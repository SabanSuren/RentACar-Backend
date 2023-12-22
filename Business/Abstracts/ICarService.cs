using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ICarService
    {
        IResult  AddCar(Car car);

       IResult DeleteCar( Car car);

      IResult UpdateCar(Car car);

        //Car GetById(int id);
       IDataResult< List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IDataResult<List<Car>> GetAllByBrandId(int id);

       IDataResult< List<Car>> GetByDailyPrice(decimal min, decimal max);

       IDataResult< List<CarDetailDto>> GetCarDetails();
    }
}
