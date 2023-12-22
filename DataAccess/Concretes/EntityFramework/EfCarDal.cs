using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarSaleContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarSaleContext context = new CarSaleContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto 
                             {CarId=c.CarId , CarName=c.CarName,Description=
                             c.Description ,BrandName=b.BrandName , ColorName=co.ColorName };

                return result.ToList();

            }
            
        }


    }
}
